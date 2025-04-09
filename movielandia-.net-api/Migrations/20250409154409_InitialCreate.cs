using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movielandia_.net_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrcProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Debut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Crews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrcProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Debut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crews", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrcProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    RatingImdb = table.Column<float>(type: "real", nullable: false),
                    DateAired = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrcProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAired = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RatingImdb = table.Column<float>(type: "real", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CanResetPassword = table.Column<bool>(type: "bit", nullable: false),
                    Subscribed = table.Column<bool>(type: "bit", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "CastMovies",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CastMovies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_CastMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "CrewMovies",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrewMovies_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_CrewMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "CastSeries",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastSeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CastSeries_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_CastSeries_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "CrewSeries",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewSeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrewSeries_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_CrewSeries_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrcProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAired = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RatingImdb = table.Column<float>(type: "real", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seasons_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "SerieGenres",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SerieGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_SerieGenres_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "ActorReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActorReviews_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_ActorReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Avatars",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avatars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avatars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "CrewReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrewReviews_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_CrewReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "MovieReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieReviews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_MovieReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "SerieReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SerieReviews_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_SerieReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserActorFavorites",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActorFavorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActorFavorites_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserActorFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserActorRatings",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActorRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActorRatings_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserActorRatings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserCrewFavorites",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCrewFavorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCrewFavorites_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserCrewFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserCrewRatings",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCrewRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCrewRatings_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserCrewRatings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserGenreFavorites",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGenreFavorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGenreFavorites_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserGenreFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserMovieFavorites",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMovieFavorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMovieFavorites_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserMovieFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserMovieRatings",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMovieRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMovieRatings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserMovieRatings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserSerieFavorites",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSerieFavorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSerieFavorites_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserSerieFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserSerieRatings",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSerieRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSerieRatings_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserSerieRatings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrcProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    DateAired = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RatingImdb = table.Column<float>(type: "real", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodes_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "SeasonReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeasonReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeasonReviews_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_SeasonReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserSeasonFavorites",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSeasonFavorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSeasonFavorites_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserSeasonFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserSeasonRatings",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSeasonRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSeasonRatings_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserSeasonRatings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "DownvoteActorReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    ActorReviewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteActorReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteActorReviews_ActorReviews_ActorReviewId",
                        column: x => x.ActorReviewId,
                        principalTable: "ActorReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteActorReviews_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteActorReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UpvoteActorReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    ActorReviewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteActorReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteActorReviews_ActorReviews_ActorReviewId",
                        column: x => x.ActorReviewId,
                        principalTable: "ActorReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteActorReviews_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteActorReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "DownvoteCrewReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false),
                    CrewReviewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteCrewReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteCrewReviews_CrewReviews_CrewReviewId",
                        column: x => x.CrewReviewId,
                        principalTable: "CrewReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteCrewReviews_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteCrewReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UpvoteCrewReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false),
                    CrewReviewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteCrewReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteCrewReviews_CrewReviews_CrewReviewId",
                        column: x => x.CrewReviewId,
                        principalTable: "CrewReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteCrewReviews_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteCrewReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "DownvoteMovieReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovieReviewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteMovieReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteMovieReviews_MovieReviews_MovieReviewId",
                        column: x => x.MovieReviewId,
                        principalTable: "MovieReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteMovieReviews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteMovieReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UpvoteMovieReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovieReviewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteMovieReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteMovieReviews_MovieReviews_MovieReviewId",
                        column: x => x.MovieReviewId,
                        principalTable: "MovieReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteMovieReviews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteMovieReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "DownvoteSerieReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    SerieReviewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteSerieReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteSerieReviews_SerieReviews_SerieReviewId",
                        column: x => x.SerieReviewId,
                        principalTable: "SerieReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteSerieReviews_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteSerieReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UpvoteSerieReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    SerieReviewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteSerieReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteSerieReviews_SerieReviews_SerieReviewId",
                        column: x => x.SerieReviewId,
                        principalTable: "SerieReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteSerieReviews_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteSerieReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "EpisodeReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpisodeReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EpisodeReviews_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_EpisodeReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserEpisodeFavorites",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEpisodeFavorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEpisodeFavorites_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserEpisodeFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserEpisodeRatings",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEpisodeRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEpisodeRatings_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserEpisodeRatings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "DownvoteSeasonReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    SeasonReviewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteSeasonReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteSeasonReviews_SeasonReviews_SeasonReviewId",
                        column: x => x.SeasonReviewId,
                        principalTable: "SeasonReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteSeasonReviews_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteSeasonReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UpvoteSeasonReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    SeasonReviewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteSeasonReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteSeasonReviews_SeasonReviews_SeasonReviewId",
                        column: x => x.SeasonReviewId,
                        principalTable: "SeasonReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteSeasonReviews_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteSeasonReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "DownvoteEpisodeReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false),
                    EpisodeReviewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteEpisodeReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteEpisodeReviews_EpisodeReviews_EpisodeReviewId",
                        column: x => x.EpisodeReviewId,
                        principalTable: "EpisodeReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteEpisodeReviews_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteEpisodeReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UpvoteEpisodeReviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false),
                    EpisodeReviewId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteEpisodeReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteEpisodeReviews_EpisodeReviews_EpisodeReviewId",
                        column: x => x.EpisodeReviewId,
                        principalTable: "EpisodeReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteEpisodeReviews_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteEpisodeReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_ActorReviews_ActorId",
                table: "ActorReviews",
                column: "ActorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ActorReviews_UserId",
                table: "ActorReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Avatars_UserId",
                table: "Avatars",
                column: "UserId",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_CastMovies_ActorId",
                table: "CastMovies",
                column: "ActorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CastMovies_MovieId",
                table: "CastMovies",
                column: "MovieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CastSeries_ActorId",
                table: "CastSeries",
                column: "ActorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CastSeries_SerieId",
                table: "CastSeries",
                column: "SerieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CrewMovies_CrewId",
                table: "CrewMovies",
                column: "CrewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CrewMovies_MovieId",
                table: "CrewMovies",
                column: "MovieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CrewReviews_CrewId",
                table: "CrewReviews",
                column: "CrewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CrewReviews_UserId",
                table: "CrewReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CrewSeries_CrewId",
                table: "CrewSeries",
                column: "CrewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CrewSeries_SerieId",
                table: "CrewSeries",
                column: "SerieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteActorReviews_ActorId",
                table: "DownvoteActorReviews",
                column: "ActorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteActorReviews_ActorReviewId",
                table: "DownvoteActorReviews",
                column: "ActorReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteActorReviews_UserId",
                table: "DownvoteActorReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteCrewReviews_CrewId",
                table: "DownvoteCrewReviews",
                column: "CrewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteCrewReviews_CrewReviewId",
                table: "DownvoteCrewReviews",
                column: "CrewReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteCrewReviews_UserId",
                table: "DownvoteCrewReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteEpisodeReviews_EpisodeId",
                table: "DownvoteEpisodeReviews",
                column: "EpisodeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteEpisodeReviews_EpisodeReviewId",
                table: "DownvoteEpisodeReviews",
                column: "EpisodeReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteEpisodeReviews_UserId",
                table: "DownvoteEpisodeReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteMovieReviews_MovieId",
                table: "DownvoteMovieReviews",
                column: "MovieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteMovieReviews_MovieReviewId",
                table: "DownvoteMovieReviews",
                column: "MovieReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteMovieReviews_UserId",
                table: "DownvoteMovieReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteSeasonReviews_SeasonId",
                table: "DownvoteSeasonReviews",
                column: "SeasonId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteSeasonReviews_SeasonReviewId",
                table: "DownvoteSeasonReviews",
                column: "SeasonReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteSeasonReviews_UserId",
                table: "DownvoteSeasonReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteSerieReviews_SerieId",
                table: "DownvoteSerieReviews",
                column: "SerieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteSerieReviews_SerieReviewId",
                table: "DownvoteSerieReviews",
                column: "SerieReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteSerieReviews_UserId",
                table: "DownvoteSerieReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeReviews_EpisodeId",
                table: "EpisodeReviews",
                column: "EpisodeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeReviews_UserId",
                table: "EpisodeReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_SeasonId",
                table: "Episodes",
                column: "SeasonId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_GenreId",
                table: "MovieGenres",
                column: "GenreId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_MovieId",
                table: "MovieGenres",
                column: "MovieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_MovieReviews_MovieId",
                table: "MovieReviews",
                column: "MovieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_MovieReviews_UserId",
                table: "MovieReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SeasonReviews_SeasonId",
                table: "SeasonReviews",
                column: "SeasonId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SeasonReviews_UserId",
                table: "SeasonReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_SerieId",
                table: "Seasons",
                column: "SerieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SerieGenres_GenreId",
                table: "SerieGenres",
                column: "GenreId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SerieGenres_SerieId",
                table: "SerieGenres",
                column: "SerieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SerieReviews_SerieId",
                table: "SerieReviews",
                column: "SerieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SerieReviews_UserId",
                table: "SerieReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteActorReviews_ActorId",
                table: "UpvoteActorReviews",
                column: "ActorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteActorReviews_ActorReviewId",
                table: "UpvoteActorReviews",
                column: "ActorReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteActorReviews_UserId",
                table: "UpvoteActorReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteCrewReviews_CrewId",
                table: "UpvoteCrewReviews",
                column: "CrewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteCrewReviews_CrewReviewId",
                table: "UpvoteCrewReviews",
                column: "CrewReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteCrewReviews_UserId",
                table: "UpvoteCrewReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteEpisodeReviews_EpisodeId",
                table: "UpvoteEpisodeReviews",
                column: "EpisodeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteEpisodeReviews_EpisodeReviewId",
                table: "UpvoteEpisodeReviews",
                column: "EpisodeReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteEpisodeReviews_UserId",
                table: "UpvoteEpisodeReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteMovieReviews_MovieId",
                table: "UpvoteMovieReviews",
                column: "MovieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteMovieReviews_MovieReviewId",
                table: "UpvoteMovieReviews",
                column: "MovieReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteMovieReviews_UserId",
                table: "UpvoteMovieReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteSeasonReviews_SeasonId",
                table: "UpvoteSeasonReviews",
                column: "SeasonId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteSeasonReviews_SeasonReviewId",
                table: "UpvoteSeasonReviews",
                column: "SeasonReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteSeasonReviews_UserId",
                table: "UpvoteSeasonReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteSerieReviews_SerieId",
                table: "UpvoteSerieReviews",
                column: "SerieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteSerieReviews_SerieReviewId",
                table: "UpvoteSerieReviews",
                column: "SerieReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteSerieReviews_UserId",
                table: "UpvoteSerieReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserActorFavorites_ActorId",
                table: "UserActorFavorites",
                column: "ActorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserActorFavorites_UserId",
                table: "UserActorFavorites",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserActorRatings_ActorId",
                table: "UserActorRatings",
                column: "ActorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserActorRatings_UserId",
                table: "UserActorRatings",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserCrewFavorites_CrewId",
                table: "UserCrewFavorites",
                column: "CrewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserCrewFavorites_UserId",
                table: "UserCrewFavorites",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserCrewRatings_CrewId",
                table: "UserCrewRatings",
                column: "CrewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserCrewRatings_UserId",
                table: "UserCrewRatings",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeFavorites_EpisodeId",
                table: "UserEpisodeFavorites",
                column: "EpisodeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeFavorites_UserId",
                table: "UserEpisodeFavorites",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeRatings_EpisodeId",
                table: "UserEpisodeRatings",
                column: "EpisodeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeRatings_UserId",
                table: "UserEpisodeRatings",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserGenreFavorites_GenreId",
                table: "UserGenreFavorites",
                column: "GenreId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserGenreFavorites_UserId",
                table: "UserGenreFavorites",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserMovieFavorites_MovieId",
                table: "UserMovieFavorites",
                column: "MovieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserMovieFavorites_UserId_MovieId",
                table: "UserMovieFavorites",
                columns: new[] { "UserId", "MovieId" },
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserMovieRatings_MovieId",
                table: "UserMovieRatings",
                column: "MovieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserMovieRatings_UserId",
                table: "UserMovieRatings",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserSeasonFavorites_SeasonId",
                table: "UserSeasonFavorites",
                column: "SeasonId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserSeasonFavorites_UserId",
                table: "UserSeasonFavorites",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserSeasonRatings_SeasonId",
                table: "UserSeasonRatings",
                column: "SeasonId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserSeasonRatings_UserId",
                table: "UserSeasonRatings",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserSerieFavorites_SerieId",
                table: "UserSerieFavorites",
                column: "SerieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserSerieFavorites_UserId_SerieId",
                table: "UserSerieFavorites",
                columns: new[] { "UserId", "SerieId" },
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserSerieRatings_SerieId",
                table: "UserSerieRatings",
                column: "SerieId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserSerieRatings_UserId",
                table: "UserSerieRatings",
                column: "UserId"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Avatars");

            migrationBuilder.DropTable(name: "CastMovies");

            migrationBuilder.DropTable(name: "CastSeries");

            migrationBuilder.DropTable(name: "CrewMovies");

            migrationBuilder.DropTable(name: "CrewSeries");

            migrationBuilder.DropTable(name: "DownvoteActorReviews");

            migrationBuilder.DropTable(name: "DownvoteCrewReviews");

            migrationBuilder.DropTable(name: "DownvoteEpisodeReviews");

            migrationBuilder.DropTable(name: "DownvoteMovieReviews");

            migrationBuilder.DropTable(name: "DownvoteSeasonReviews");

            migrationBuilder.DropTable(name: "DownvoteSerieReviews");

            migrationBuilder.DropTable(name: "MovieGenres");

            migrationBuilder.DropTable(name: "SerieGenres");

            migrationBuilder.DropTable(name: "UpvoteActorReviews");

            migrationBuilder.DropTable(name: "UpvoteCrewReviews");

            migrationBuilder.DropTable(name: "UpvoteEpisodeReviews");

            migrationBuilder.DropTable(name: "UpvoteMovieReviews");

            migrationBuilder.DropTable(name: "UpvoteSeasonReviews");

            migrationBuilder.DropTable(name: "UpvoteSerieReviews");

            migrationBuilder.DropTable(name: "UserActorFavorites");

            migrationBuilder.DropTable(name: "UserActorRatings");

            migrationBuilder.DropTable(name: "UserCrewFavorites");

            migrationBuilder.DropTable(name: "UserCrewRatings");

            migrationBuilder.DropTable(name: "UserEpisodeFavorites");

            migrationBuilder.DropTable(name: "UserEpisodeRatings");

            migrationBuilder.DropTable(name: "UserGenreFavorites");

            migrationBuilder.DropTable(name: "UserMovieFavorites");

            migrationBuilder.DropTable(name: "UserMovieRatings");

            migrationBuilder.DropTable(name: "UserSeasonFavorites");

            migrationBuilder.DropTable(name: "UserSeasonRatings");

            migrationBuilder.DropTable(name: "UserSerieFavorites");

            migrationBuilder.DropTable(name: "UserSerieRatings");

            migrationBuilder.DropTable(name: "ActorReviews");

            migrationBuilder.DropTable(name: "CrewReviews");

            migrationBuilder.DropTable(name: "EpisodeReviews");

            migrationBuilder.DropTable(name: "MovieReviews");

            migrationBuilder.DropTable(name: "SeasonReviews");

            migrationBuilder.DropTable(name: "SerieReviews");

            migrationBuilder.DropTable(name: "Genres");

            migrationBuilder.DropTable(name: "Actors");

            migrationBuilder.DropTable(name: "Crews");

            migrationBuilder.DropTable(name: "Episodes");

            migrationBuilder.DropTable(name: "Movies");

            migrationBuilder.DropTable(name: "Users");

            migrationBuilder.DropTable(name: "Seasons");

            migrationBuilder.DropTable(name: "Series");
        }
    }
}
