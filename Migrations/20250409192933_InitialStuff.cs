using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movielandia_.net_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialStuff : Migration
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
                name: "ForumTag",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTag", x => x.Id);
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
                name: "Inbox",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inbox", x => x.Id);
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
                    ActorId1 = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_ActorReviews_Actors_ActorId1",
                        column: x => x.ActorId1,
                        principalTable: "Actors",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_ActorReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                    CrewId1 = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_CrewReviews_Crews_CrewId1",
                        column: x => x.CrewId1,
                        principalTable: "Crews",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_CrewReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Read = table.Column<bool>(type: "bit", nullable: false),
                    EditedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ReceiverId = table.Column<int>(type: "int", nullable: false),
                    InboxId = table.Column<int>(type: "int", nullable: false),
                    InboxId1 = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_Inbox_InboxId",
                        column: x => x.InboxId,
                        principalTable: "Inbox",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_Message_Inbox_InboxId1",
                        column: x => x.InboxId1,
                        principalTable: "Inbox",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_Message_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_Message_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_Message_Users_UserId",
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
                    MovieId1 = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_MovieReviews_Movies_MovieId1",
                        column: x => x.MovieId1,
                        principalTable: "Movies",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_MovieReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                    SerieId1 = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_SerieReviews_Series_SerieId1",
                        column: x => x.SerieId1,
                        principalTable: "Series",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_SerieReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                name: "UserInbox",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InboxId = table.Column<int>(type: "int", nullable: false),
                    InboxId1 = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInbox", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInbox_Inbox_InboxId",
                        column: x => x.InboxId,
                        principalTable: "Inbox",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserInbox_Inbox_InboxId1",
                        column: x => x.InboxId1,
                        principalTable: "Inbox",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UserInbox_Users_UserId",
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
                    SeasonId1 = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_SeasonReviews_Seasons_SeasonId1",
                        column: x => x.SeasonId1,
                        principalTable: "Seasons",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_SeasonReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteActorReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteActorReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "DownvoteCrewReview",
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
                    table.PrimaryKey("PK_DownvoteCrewReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteCrewReview_CrewReviews_CrewReviewId",
                        column: x => x.CrewReviewId,
                        principalTable: "CrewReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteCrewReview_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteCrewReview_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UpvoteCrewReview",
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
                    table.PrimaryKey("PK_UpvoteCrewReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteCrewReview_CrewReviews_CrewReviewId",
                        column: x => x.CrewReviewId,
                        principalTable: "CrewReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteCrewReview_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteCrewReview_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteMovieReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteMovieReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteSerieReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteSerieReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                    EpisodeId1 = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_EpisodeReviews_Episodes_EpisodeId1",
                        column: x => x.EpisodeId1,
                        principalTable: "Episodes",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_EpisodeReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                    EpisodeId1 = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_UserEpisodeFavorites_Episodes_EpisodeId1",
                        column: x => x.EpisodeId1,
                        principalTable: "Episodes",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UserEpisodeFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserEpisodeFavorites_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                    EpisodeId1 = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_UserEpisodeRatings_Episodes_EpisodeId1",
                        column: x => x.EpisodeId1,
                        principalTable: "Episodes",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UserEpisodeRatings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserEpisodeRatings_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteSeasonReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteSeasonReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_DownvoteEpisodeReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
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
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteEpisodeReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "DownvoteForumPost",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    ForumPostId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteForumPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteForumPost_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "DownvoteForumReply",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ReplyId = table.Column<int>(type: "int", nullable: false),
                    ForumReplyId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteForumReply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteForumReply_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "DownvoteForumTopic",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    ForumTopicId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteForumTopic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteForumTopic_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "ForumCategory",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopicCount = table.Column<int>(type: "int", nullable: false),
                    PostCount = table.Column<int>(type: "int", nullable: false),
                    LastPostAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastPostId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumCategory", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "ForumTopic",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    IsPinned = table.Column<bool>(type: "bit", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastPostAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsModerated = table.Column<bool>(type: "bit", nullable: false),
                    ClosedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ClosedById = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ForumCategoryId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTopic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumTopic_ForumCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ForumCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_ForumTopic_ForumCategory_ForumCategoryId",
                        column: x => x.ForumCategoryId,
                        principalTable: "ForumCategory",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_ForumTopic_Users_ClosedById",
                        column: x => x.ClosedById,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_ForumTopic_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserForumModerator",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ForumCategoryId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserForumModerator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserForumModerator_ForumCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ForumCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserForumModerator_ForumCategory_ForumCategoryId",
                        column: x => x.ForumCategoryId,
                        principalTable: "ForumCategory",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UserForumModerator_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "ForumPost",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsEdited = table.Column<bool>(type: "bit", nullable: false),
                    EditCount = table.Column<int>(type: "int", nullable: false),
                    LastEditAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsModerated = table.Column<bool>(type: "bit", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    IsAnswer = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    AnsweredAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AnsweredById = table.Column<int>(type: "int", nullable: true),
                    DeletedById = table.Column<int>(type: "int", nullable: true),
                    ForumTopicId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumPost_ForumTopic_ForumTopicId",
                        column: x => x.ForumTopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_ForumPost_ForumTopic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_ForumPost_Users_AnsweredById",
                        column: x => x.AnsweredById,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_ForumPost_Users_DeletedById",
                        column: x => x.DeletedById,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_ForumPost_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "ForumTagForumTopic",
                columns: table => new
                {
                    TagsId = table.Column<int>(type: "int", nullable: false),
                    TopicsId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTagForumTopic", x => new { x.TagsId, x.TopicsId });
                    table.ForeignKey(
                        name: "FK_ForumTagForumTopic_ForumTag_TagsId",
                        column: x => x.TagsId,
                        principalTable: "ForumTag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_ForumTagForumTopic_ForumTopic_TopicsId",
                        column: x => x.TopicsId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UpvoteForumTopic",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    ForumTopicId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteForumTopic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteForumTopic_ForumTopic_ForumTopicId",
                        column: x => x.ForumTopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteForumTopic_ForumTopic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteForumTopic_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserForumTopicFavorite",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    ForumTopicId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserForumTopicFavorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserForumTopicFavorite_ForumTopic_ForumTopicId",
                        column: x => x.ForumTopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UserForumTopicFavorite_ForumTopic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserForumTopicFavorite_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserForumTopicWatch",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    ForumTopicId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserForumTopicWatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserForumTopicWatch_ForumTopic_ForumTopicId",
                        column: x => x.ForumTopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UserForumTopicWatch_ForumTopic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserForumTopicWatch_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "ForumPostHistory",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OldContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    EditedById = table.Column<int>(type: "int", nullable: false),
                    ForumPostId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPostHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumPostHistory_ForumPost_ForumPostId",
                        column: x => x.ForumPostId,
                        principalTable: "ForumPost",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_ForumPostHistory_ForumPost_PostId",
                        column: x => x.PostId,
                        principalTable: "ForumPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_ForumPostHistory_Users_EditedById",
                        column: x => x.EditedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "ForumReply",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsEdited = table.Column<bool>(type: "bit", nullable: false),
                    EditCount = table.Column<int>(type: "int", nullable: false),
                    LastEditAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsModerated = table.Column<bool>(type: "bit", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ForumPostId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumReply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumReply_ForumPost_ForumPostId",
                        column: x => x.ForumPostId,
                        principalTable: "ForumPost",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_ForumReply_ForumPost_PostId",
                        column: x => x.PostId,
                        principalTable: "ForumPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_ForumReply_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UpvoteForumPost",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    ForumPostId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteForumPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteForumPost_ForumPost_ForumPostId",
                        column: x => x.ForumPostId,
                        principalTable: "ForumPost",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteForumPost_ForumPost_PostId",
                        column: x => x.PostId,
                        principalTable: "ForumPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteForumPost_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "ForumReplyHistory",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OldContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReplyId = table.Column<int>(type: "int", nullable: false),
                    EditedById = table.Column<int>(type: "int", nullable: false),
                    ForumReplyId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumReplyHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumReplyHistory_ForumReply_ForumReplyId",
                        column: x => x.ForumReplyId,
                        principalTable: "ForumReply",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_ForumReplyHistory_ForumReply_ReplyId",
                        column: x => x.ReplyId,
                        principalTable: "ForumReply",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_ForumReplyHistory_Users_EditedById",
                        column: x => x.EditedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UpvoteForumReply",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ReplyId = table.Column<int>(type: "int", nullable: false),
                    ForumReplyId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteForumReply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteForumReply_ForumReply_ForumReplyId",
                        column: x => x.ForumReplyId,
                        principalTable: "ForumReply",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteForumReply_ForumReply_ReplyId",
                        column: x => x.ReplyId,
                        principalTable: "ForumReply",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UpvoteForumReply_Users_UserId",
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
                name: "IX_ActorReviews_ActorId1",
                table: "ActorReviews",
                column: "ActorId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ActorReviews_UserId",
                table: "ActorReviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_PostId",
                table: "Attachment",
                column: "PostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_UserId",
                table: "Attachment",
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
                name: "IX_CrewReviews_CrewId1",
                table: "CrewReviews",
                column: "CrewId1"
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
                name: "IX_DownvoteCrewReview_CrewId",
                table: "DownvoteCrewReview",
                column: "CrewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteCrewReview_CrewReviewId",
                table: "DownvoteCrewReview",
                column: "CrewReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteCrewReview_UserId",
                table: "DownvoteCrewReview",
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
                name: "IX_DownvoteForumPost_ForumPostId",
                table: "DownvoteForumPost",
                column: "ForumPostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumPost_PostId",
                table: "DownvoteForumPost",
                column: "PostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumPost_UserId",
                table: "DownvoteForumPost",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumReply_ForumReplyId",
                table: "DownvoteForumReply",
                column: "ForumReplyId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumReply_ReplyId",
                table: "DownvoteForumReply",
                column: "ReplyId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumReply_UserId",
                table: "DownvoteForumReply",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumTopic_ForumTopicId",
                table: "DownvoteForumTopic",
                column: "ForumTopicId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumTopic_TopicId",
                table: "DownvoteForumTopic",
                column: "TopicId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumTopic_UserId",
                table: "DownvoteForumTopic",
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
                name: "IX_EpisodeReviews_EpisodeId1",
                table: "EpisodeReviews",
                column: "EpisodeId1"
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
                name: "IX_ForumCategory_LastPostId",
                table: "ForumCategory",
                column: "LastPostId",
                unique: true,
                filter: "[LastPostId] IS NOT NULL"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumPost_AnsweredById",
                table: "ForumPost",
                column: "AnsweredById"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumPost_DeletedById",
                table: "ForumPost",
                column: "DeletedById"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumPost_ForumTopicId",
                table: "ForumPost",
                column: "ForumTopicId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumPost_TopicId",
                table: "ForumPost",
                column: "TopicId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumPost_UserId",
                table: "ForumPost",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumPostHistory_EditedById",
                table: "ForumPostHistory",
                column: "EditedById"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumPostHistory_ForumPostId",
                table: "ForumPostHistory",
                column: "ForumPostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumPostHistory_PostId",
                table: "ForumPostHistory",
                column: "PostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumReply_ForumPostId",
                table: "ForumReply",
                column: "ForumPostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumReply_PostId",
                table: "ForumReply",
                column: "PostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumReply_UserId",
                table: "ForumReply",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumReplyHistory_EditedById",
                table: "ForumReplyHistory",
                column: "EditedById"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumReplyHistory_ForumReplyId",
                table: "ForumReplyHistory",
                column: "ForumReplyId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumReplyHistory_ReplyId",
                table: "ForumReplyHistory",
                column: "ReplyId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumTagForumTopic_TopicsId",
                table: "ForumTagForumTopic",
                column: "TopicsId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_CategoryId",
                table: "ForumTopic",
                column: "CategoryId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_ClosedById",
                table: "ForumTopic",
                column: "ClosedById"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_ForumCategoryId",
                table: "ForumTopic",
                column: "ForumCategoryId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_UserId",
                table: "ForumTopic",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Message_InboxId",
                table: "Message",
                column: "InboxId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Message_InboxId1",
                table: "Message",
                column: "InboxId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Message_ReceiverId",
                table: "Message",
                column: "ReceiverId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Message_SenderId",
                table: "Message",
                column: "SenderId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserId",
                table: "Message",
                column: "UserId"
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
                name: "IX_MovieReviews_MovieId1",
                table: "MovieReviews",
                column: "MovieId1"
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
                name: "IX_SeasonReviews_SeasonId1",
                table: "SeasonReviews",
                column: "SeasonId1"
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
                name: "IX_SerieReviews_SerieId1",
                table: "SerieReviews",
                column: "SerieId1"
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
                name: "IX_UpvoteCrewReview_CrewId",
                table: "UpvoteCrewReview",
                column: "CrewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteCrewReview_CrewReviewId",
                table: "UpvoteCrewReview",
                column: "CrewReviewId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteCrewReview_UserId",
                table: "UpvoteCrewReview",
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
                name: "IX_UpvoteForumPost_ForumPostId",
                table: "UpvoteForumPost",
                column: "ForumPostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumPost_PostId",
                table: "UpvoteForumPost",
                column: "PostId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumPost_UserId",
                table: "UpvoteForumPost",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumReply_ForumReplyId",
                table: "UpvoteForumReply",
                column: "ForumReplyId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumReply_ReplyId",
                table: "UpvoteForumReply",
                column: "ReplyId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumReply_UserId",
                table: "UpvoteForumReply",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumTopic_ForumTopicId",
                table: "UpvoteForumTopic",
                column: "ForumTopicId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumTopic_TopicId",
                table: "UpvoteForumTopic",
                column: "TopicId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumTopic_UserId",
                table: "UpvoteForumTopic",
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
                name: "IX_UserEpisodeFavorites_EpisodeId1",
                table: "UserEpisodeFavorites",
                column: "EpisodeId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeFavorites_UserId",
                table: "UserEpisodeFavorites",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeFavorites_UserId1",
                table: "UserEpisodeFavorites",
                column: "UserId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeRatings_EpisodeId",
                table: "UserEpisodeRatings",
                column: "EpisodeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeRatings_EpisodeId1",
                table: "UserEpisodeRatings",
                column: "EpisodeId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeRatings_UserId",
                table: "UserEpisodeRatings",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeRatings_UserId1",
                table: "UserEpisodeRatings",
                column: "UserId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserForumModerator_CategoryId",
                table: "UserForumModerator",
                column: "CategoryId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserForumModerator_ForumCategoryId",
                table: "UserForumModerator",
                column: "ForumCategoryId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserForumModerator_UserId",
                table: "UserForumModerator",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicFavorite_ForumTopicId",
                table: "UserForumTopicFavorite",
                column: "ForumTopicId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicFavorite_TopicId",
                table: "UserForumTopicFavorite",
                column: "TopicId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicFavorite_UserId",
                table: "UserForumTopicFavorite",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicWatch_ForumTopicId",
                table: "UserForumTopicWatch",
                column: "ForumTopicId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicWatch_TopicId",
                table: "UserForumTopicWatch",
                column: "TopicId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicWatch_UserId",
                table: "UserForumTopicWatch",
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
                name: "IX_UserInbox_InboxId",
                table: "UserInbox",
                column: "InboxId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserInbox_InboxId1",
                table: "UserInbox",
                column: "InboxId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserInbox_UserId",
                table: "UserInbox",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_ForumPost_PostId",
                table: "Attachment",
                column: "PostId",
                principalTable: "ForumPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteForumPost_ForumPost_ForumPostId",
                table: "DownvoteForumPost",
                column: "ForumPostId",
                principalTable: "ForumPost",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteForumPost_ForumPost_PostId",
                table: "DownvoteForumPost",
                column: "PostId",
                principalTable: "ForumPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteForumReply_ForumReply_ForumReplyId",
                table: "DownvoteForumReply",
                column: "ForumReplyId",
                principalTable: "ForumReply",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteForumReply_ForumReply_ReplyId",
                table: "DownvoteForumReply",
                column: "ReplyId",
                principalTable: "ForumReply",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteForumTopic_ForumTopic_ForumTopicId",
                table: "DownvoteForumTopic",
                column: "ForumTopicId",
                principalTable: "ForumTopic",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteForumTopic_ForumTopic_TopicId",
                table: "DownvoteForumTopic",
                column: "TopicId",
                principalTable: "ForumTopic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_ForumCategory_ForumPost_LastPostId",
                table: "ForumCategory",
                column: "LastPostId",
                principalTable: "ForumPost",
                principalColumn: "Id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumPost_Users_AnsweredById",
                table: "ForumPost"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_ForumPost_Users_DeletedById",
                table: "ForumPost"
            );

            migrationBuilder.DropForeignKey(name: "FK_ForumPost_Users_UserId", table: "ForumPost");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumTopic_Users_ClosedById",
                table: "ForumTopic"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_ForumTopic_Users_UserId",
                table: "ForumTopic"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_ForumCategory_ForumPost_LastPostId",
                table: "ForumCategory"
            );

            migrationBuilder.DropTable(name: "Attachment");

            migrationBuilder.DropTable(name: "Avatars");

            migrationBuilder.DropTable(name: "CastMovies");

            migrationBuilder.DropTable(name: "CastSeries");

            migrationBuilder.DropTable(name: "CrewMovies");

            migrationBuilder.DropTable(name: "CrewSeries");

            migrationBuilder.DropTable(name: "DownvoteActorReviews");

            migrationBuilder.DropTable(name: "DownvoteCrewReview");

            migrationBuilder.DropTable(name: "DownvoteEpisodeReviews");

            migrationBuilder.DropTable(name: "DownvoteForumPost");

            migrationBuilder.DropTable(name: "DownvoteForumReply");

            migrationBuilder.DropTable(name: "DownvoteForumTopic");

            migrationBuilder.DropTable(name: "DownvoteMovieReviews");

            migrationBuilder.DropTable(name: "DownvoteSeasonReviews");

            migrationBuilder.DropTable(name: "DownvoteSerieReviews");

            migrationBuilder.DropTable(name: "ForumPostHistory");

            migrationBuilder.DropTable(name: "ForumReplyHistory");

            migrationBuilder.DropTable(name: "ForumTagForumTopic");

            migrationBuilder.DropTable(name: "Message");

            migrationBuilder.DropTable(name: "MovieGenres");

            migrationBuilder.DropTable(name: "SerieGenres");

            migrationBuilder.DropTable(name: "UpvoteActorReviews");

            migrationBuilder.DropTable(name: "UpvoteCrewReview");

            migrationBuilder.DropTable(name: "UpvoteEpisodeReviews");

            migrationBuilder.DropTable(name: "UpvoteForumPost");

            migrationBuilder.DropTable(name: "UpvoteForumReply");

            migrationBuilder.DropTable(name: "UpvoteForumTopic");

            migrationBuilder.DropTable(name: "UpvoteMovieReviews");

            migrationBuilder.DropTable(name: "UpvoteSeasonReviews");

            migrationBuilder.DropTable(name: "UpvoteSerieReviews");

            migrationBuilder.DropTable(name: "UserActorFavorites");

            migrationBuilder.DropTable(name: "UserActorRatings");

            migrationBuilder.DropTable(name: "UserCrewFavorites");

            migrationBuilder.DropTable(name: "UserCrewRatings");

            migrationBuilder.DropTable(name: "UserEpisodeFavorites");

            migrationBuilder.DropTable(name: "UserEpisodeRatings");

            migrationBuilder.DropTable(name: "UserForumModerator");

            migrationBuilder.DropTable(name: "UserForumTopicFavorite");

            migrationBuilder.DropTable(name: "UserForumTopicWatch");

            migrationBuilder.DropTable(name: "UserGenreFavorites");

            migrationBuilder.DropTable(name: "UserInbox");

            migrationBuilder.DropTable(name: "UserMovieFavorites");

            migrationBuilder.DropTable(name: "UserMovieRatings");

            migrationBuilder.DropTable(name: "UserSeasonFavorites");

            migrationBuilder.DropTable(name: "UserSeasonRatings");

            migrationBuilder.DropTable(name: "UserSerieFavorites");

            migrationBuilder.DropTable(name: "UserSerieRatings");

            migrationBuilder.DropTable(name: "ForumTag");

            migrationBuilder.DropTable(name: "ActorReviews");

            migrationBuilder.DropTable(name: "CrewReviews");

            migrationBuilder.DropTable(name: "EpisodeReviews");

            migrationBuilder.DropTable(name: "ForumReply");

            migrationBuilder.DropTable(name: "MovieReviews");

            migrationBuilder.DropTable(name: "SeasonReviews");

            migrationBuilder.DropTable(name: "SerieReviews");

            migrationBuilder.DropTable(name: "Genres");

            migrationBuilder.DropTable(name: "Inbox");

            migrationBuilder.DropTable(name: "Actors");

            migrationBuilder.DropTable(name: "Crews");

            migrationBuilder.DropTable(name: "Episodes");

            migrationBuilder.DropTable(name: "Movies");

            migrationBuilder.DropTable(name: "Seasons");

            migrationBuilder.DropTable(name: "Series");

            migrationBuilder.DropTable(name: "Users");

            migrationBuilder.DropTable(name: "ForumPost");

            migrationBuilder.DropTable(name: "ForumTopic");

            migrationBuilder.DropTable(name: "ForumCategory");
        }
    }
}
