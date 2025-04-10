using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movielandia_.net_api.Migrations
{
    /// <inheritdoc />
    public partial class InitTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrcProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Debut = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Crew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrcProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Debut = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crew", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForumTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inbox",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inbox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrcProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    RatingImdb = table.Column<float>(type: "real", nullable: false),
                    DateAired = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsGlobal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrcProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAired = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RatingImdb = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    Subscribed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinPoints = table.Column<int>(type: "int", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CastMovie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastMovie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CastMovie_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastMovie_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewMovie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewMovie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrewMovie_Crew_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrewMovie_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieGenre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenre_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CastSerie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastSerie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CastSerie_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastSerie_Serie_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewSerie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewSerie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrewSerie_Crew_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrewSerie_Serie_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Season",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrcProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAired = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RatingImdb = table.Column<float>(type: "real", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Season_Serie_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SerieGenre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieGenre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SerieGenre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SerieGenre_Serie_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccessToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiresAt = table.Column<int>(type: "int", nullable: true),
                    TokenType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scope = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProviderAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    ActorId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActorReview_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorReview_Actor_ActorId1",
                        column: x => x.ActorId1,
                        principalTable: "Actor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActorReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Avatar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avatar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avatar_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentChangeLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OldValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChangedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentChangeLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentChangeLog_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Changes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentHistory_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false),
                    CrewId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrewReview_Crew_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrewReview_Crew_CrewId1",
                        column: x => x.CrewId1,
                        principalTable: "Crew",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CrewReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForumUserStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPosts = table.Column<int>(type: "int", nullable: false),
                    TotalTopics = table.Column<int>(type: "int", nullable: false),
                    TotalReplies = table.Column<int>(type: "int", nullable: false),
                    TopicsViewed = table.Column<int>(type: "int", nullable: false),
                    LastActive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reputation = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumUserStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumUserStats_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumUserStats_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "List",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List", x => x.Id);
                    table.ForeignKey(
                        name: "FK_List_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_List_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Read = table.Column<bool>(type: "bit", nullable: false),
                    EditedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ReceiverId = table.Column<int>(type: "int", nullable: false),
                    InboxId = table.Column<int>(type: "int", nullable: false),
                    InboxId1 = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_Inbox_InboxId",
                        column: x => x.InboxId,
                        principalTable: "Inbox",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Message_Inbox_InboxId1",
                        column: x => x.InboxId1,
                        principalTable: "Inbox",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Message_User_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Message_User_SenderId",
                        column: x => x.SenderId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Message_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovieId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieReview_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieReview_Movie_MovieId1",
                        column: x => x.MovieId1,
                        principalTable: "Movie",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MovieReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NotificationUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    ReadAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationUser_Notification_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SerieReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    SerieId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SerieReview_Serie_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SerieReview_Serie_SerieId1",
                        column: x => x.SerieId1,
                        principalTable: "Serie",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SerieReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SessionToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Session_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserActivity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: true),
                    Metadata = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActivity_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserActorFavorite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActorFavorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActorFavorite_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserActorFavorite_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserActorRating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActorRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActorRating_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserActorRating_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBlock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlockerId = table.Column<int>(type: "int", nullable: false),
                    BlockedId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBlock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBlock_User_BlockedId",
                        column: x => x.BlockedId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserBlock_User_BlockerId",
                        column: x => x.BlockerId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserBlock_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserBlock_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserContact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserContact_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCrewFavorite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCrewFavorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCrewFavorite_Crew_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCrewFavorite_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCrewRating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCrewRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCrewRating_Crew_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCrewRating_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFollow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FollowedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FollowerId = table.Column<int>(type: "int", nullable: false),
                    FollowingId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFollow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFollow_User_FollowerId",
                        column: x => x.FollowerId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserFollow_User_FollowingId",
                        column: x => x.FollowingId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserFollow_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserFollow_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserGenreFavorite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGenreFavorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGenreFavorite_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGenreFavorite_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInbox",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InboxId = table.Column<int>(type: "int", nullable: false),
                    InboxId1 = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInbox", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInbox_Inbox_InboxId",
                        column: x => x.InboxId,
                        principalTable: "Inbox",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInbox_Inbox_InboxId1",
                        column: x => x.InboxId1,
                        principalTable: "Inbox",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserInbox_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInbox_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserMovieFavorite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMovieFavorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMovieFavorite_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMovieFavorite_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMovieRating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMovieRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMovieRating_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMovieRating_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMute",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MutedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MutedUserId = table.Column<int>(type: "int", nullable: false),
                    ModeratorId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMute_User_ModeratorId",
                        column: x => x.ModeratorId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserMute_User_MutedUserId",
                        column: x => x.MutedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserMute_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserMute_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserNotificationSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailNotifications = table.Column<bool>(type: "bit", nullable: false),
                    PushNotifications = table.Column<bool>(type: "bit", nullable: false),
                    ForumNotifications = table.Column<bool>(type: "bit", nullable: false),
                    ReviewNotifications = table.Column<bool>(type: "bit", nullable: false),
                    FollowerNotifications = table.Column<bool>(type: "bit", nullable: false),
                    MessageNotifications = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotificationSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNotificationSettings_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResolvedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReporterId = table.Column<int>(type: "int", nullable: false),
                    ReportedUserId = table.Column<int>(type: "int", nullable: false),
                    ModeratorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReport_User_ModeratorId",
                        column: x => x.ModeratorId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserReport_User_ReportedUserId",
                        column: x => x.ReportedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserReport_User_ReporterId",
                        column: x => x.ReporterId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserSerieFavorite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSerieFavorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSerieFavorite_Serie_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSerieFavorite_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSerieRating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSerieRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSerieRating_Serie_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSerieRating_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBadge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AwardedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RankId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBadge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBadge_UserRank_RankId",
                        column: x => x.RankId,
                        principalTable: "UserRank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBadge_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBadge_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Episode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoSrcProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    DateAired = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RatingImdb = table.Column<float>(type: "real", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episode_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeasonReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    SeasonId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeasonReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeasonReview_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeasonReview_Season_SeasonId1",
                        column: x => x.SeasonId1,
                        principalTable: "Season",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SeasonReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserSeasonFavorite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSeasonFavorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSeasonFavorite_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSeasonFavorite_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSeasonRating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSeasonRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSeasonRating_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSeasonRating_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DownvoteActorReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    ActorReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteActorReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteActorReview_ActorReview_ActorReviewId",
                        column: x => x.ActorReviewId,
                        principalTable: "ActorReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DownvoteActorReview_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DownvoteActorReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UpvoteActorReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    ActorReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteActorReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteActorReview_ActorReview_ActorReviewId",
                        column: x => x.ActorReviewId,
                        principalTable: "ActorReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpvoteActorReview_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UpvoteActorReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DownvoteCrewReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false),
                    CrewReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteCrewReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteCrewReview_CrewReview_CrewReviewId",
                        column: x => x.CrewReviewId,
                        principalTable: "CrewReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DownvoteCrewReview_Crew_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crew",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DownvoteCrewReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UpvoteCrewReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false),
                    CrewReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteCrewReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteCrewReview_CrewReview_CrewReviewId",
                        column: x => x.CrewReviewId,
                        principalTable: "CrewReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpvoteCrewReview_Crew_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crew",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UpvoteCrewReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ListActor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListActor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListActor_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListActor_List_ListId",
                        column: x => x.ListId,
                        principalTable: "List",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListCrew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListId = table.Column<int>(type: "int", nullable: false),
                    CrewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListCrew", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListCrew_Crew_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListCrew_List_ListId",
                        column: x => x.ListId,
                        principalTable: "List",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListMovie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListMovie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListMovie_List_ListId",
                        column: x => x.ListId,
                        principalTable: "List",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListMovie_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListSeason",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListSeason", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListSeason_List_ListId",
                        column: x => x.ListId,
                        principalTable: "List",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListSeason_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListSerie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListSerie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListSerie_List_ListId",
                        column: x => x.ListId,
                        principalTable: "List",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListSerie_Serie_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DownvoteMovieReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovieReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteMovieReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteMovieReview_MovieReview_MovieReviewId",
                        column: x => x.MovieReviewId,
                        principalTable: "MovieReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DownvoteMovieReview_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DownvoteMovieReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UpvoteMovieReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovieReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteMovieReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteMovieReview_MovieReview_MovieReviewId",
                        column: x => x.MovieReviewId,
                        principalTable: "MovieReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpvoteMovieReview_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UpvoteMovieReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DownvoteSerieReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    SerieReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteSerieReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteSerieReview_SerieReview_SerieReviewId",
                        column: x => x.SerieReviewId,
                        principalTable: "SerieReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DownvoteSerieReview_Serie_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Serie",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DownvoteSerieReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UpvoteSerieReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    SerieReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteSerieReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteSerieReview_SerieReview_SerieReviewId",
                        column: x => x.SerieReviewId,
                        principalTable: "SerieReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpvoteSerieReview_Serie_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Serie",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UpvoteSerieReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EpisodeReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpisodeReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EpisodeReview_Episode_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EpisodeReview_Episode_EpisodeId1",
                        column: x => x.EpisodeId1,
                        principalTable: "Episode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EpisodeReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ListEpisode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListEpisode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListEpisode_Episode_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListEpisode_List_ListId",
                        column: x => x.ListId,
                        principalTable: "List",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEpisodeFavorite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId1 = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEpisodeFavorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEpisodeFavorite_Episode_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEpisodeFavorite_Episode_EpisodeId1",
                        column: x => x.EpisodeId1,
                        principalTable: "Episode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEpisodeFavorite_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEpisodeFavorite_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserEpisodeRating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId1 = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEpisodeRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEpisodeRating_Episode_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEpisodeRating_Episode_EpisodeId1",
                        column: x => x.EpisodeId1,
                        principalTable: "Episode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEpisodeRating_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEpisodeRating_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DownvoteSeasonReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    SeasonReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteSeasonReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteSeasonReview_SeasonReview_SeasonReviewId",
                        column: x => x.SeasonReviewId,
                        principalTable: "SeasonReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DownvoteSeasonReview_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Season",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DownvoteSeasonReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UpvoteSeasonReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    SeasonReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteSeasonReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteSeasonReview_SeasonReview_SeasonReviewId",
                        column: x => x.SeasonReviewId,
                        principalTable: "SeasonReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpvoteSeasonReview_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Season",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UpvoteSeasonReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DownvoteEpisodeReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false),
                    EpisodeReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteEpisodeReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteEpisodeReview_EpisodeReview_EpisodeReviewId",
                        column: x => x.EpisodeReviewId,
                        principalTable: "EpisodeReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DownvoteEpisodeReview_Episode_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DownvoteEpisodeReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UpvoteEpisodeReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false),
                    EpisodeReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteEpisodeReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteEpisodeReview_EpisodeReview_EpisodeReviewId",
                        column: x => x.EpisodeReviewId,
                        principalTable: "EpisodeReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpvoteEpisodeReview_Episode_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UpvoteEpisodeReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DownvoteForumPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    ForumPostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteForumPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteForumPost_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DownvoteForumReply",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ReplyId = table.Column<int>(type: "int", nullable: false),
                    ForumReplyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteForumReply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteForumReply_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DownvoteForumTopic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    ForumTopicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownvoteForumTopic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownvoteForumTopic_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForumCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    LastPostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForumTopic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    ForumCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTopic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumTopic_ForumCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ForumCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumTopic_ForumCategory_ForumCategoryId",
                        column: x => x.ForumCategoryId,
                        principalTable: "ForumCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForumTopic_User_ClosedById",
                        column: x => x.ClosedById,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForumTopic_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserForumModerator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ForumCategoryId = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserForumModerator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserForumModerator_ForumCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ForumCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserForumModerator_ForumCategory_ForumCategoryId",
                        column: x => x.ForumCategoryId,
                        principalTable: "ForumCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserForumModerator_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserForumModerator_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForumPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    ForumCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumPost_ForumCategory_ForumCategoryId",
                        column: x => x.ForumCategoryId,
                        principalTable: "ForumCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForumPost_ForumTopic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumPost_User_AnsweredById",
                        column: x => x.AnsweredById,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForumPost_User_DeletedById",
                        column: x => x.DeletedById,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForumPost_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForumTagForumTopic",
                columns: table => new
                {
                    TagsId = table.Column<int>(type: "int", nullable: false),
                    TopicsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTagForumTopic", x => new { x.TagsId, x.TopicsId });
                    table.ForeignKey(
                        name: "FK_ForumTagForumTopic_ForumTag_TagsId",
                        column: x => x.TagsId,
                        principalTable: "ForumTag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumTagForumTopic_ForumTopic_TopicsId",
                        column: x => x.TopicsId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UpvoteForumTopic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    ForumTopicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteForumTopic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteForumTopic_ForumTopic_ForumTopicId",
                        column: x => x.ForumTopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UpvoteForumTopic_ForumTopic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpvoteForumTopic_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserForumTopicFavorite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    ForumTopicId = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserForumTopicFavorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserForumTopicFavorite_ForumTopic_ForumTopicId",
                        column: x => x.ForumTopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserForumTopicFavorite_ForumTopic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserForumTopicFavorite_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserForumTopicFavorite_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserForumTopicWatch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    ForumTopicId = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserForumTopicWatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserForumTopicWatch_ForumTopic_ForumTopicId",
                        column: x => x.ForumTopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserForumTopicWatch_ForumTopic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserForumTopicWatch_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserForumTopicWatch_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForumLogHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    TopicId = table.Column<int>(type: "int", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumLogHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumLogHistory_ForumCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ForumCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForumLogHistory_ForumPost_PostId",
                        column: x => x.PostId,
                        principalTable: "ForumPost",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForumLogHistory_ForumTopic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "ForumTopic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForumLogHistory_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForumPostHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OldContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    EditedById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPostHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumPostHistory_ForumPost_PostId",
                        column: x => x.PostId,
                        principalTable: "ForumPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumPostHistory_User_EditedById",
                        column: x => x.EditedById,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForumReply",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsEdited = table.Column<bool>(type: "bit", nullable: false),
                    EditCount = table.Column<int>(type: "int", nullable: false),
                    LastEditAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsModerated = table.Column<bool>(type: "bit", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumReply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumReply_ForumPost_PostId",
                        column: x => x.PostId,
                        principalTable: "ForumPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumReply_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UpvoteForumPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    ForumPostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteForumPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteForumPost_ForumPost_ForumPostId",
                        column: x => x.ForumPostId,
                        principalTable: "ForumPost",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UpvoteForumPost_ForumPost_PostId",
                        column: x => x.PostId,
                        principalTable: "ForumPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpvoteForumPost_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForumReplyHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OldContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReplyId = table.Column<int>(type: "int", nullable: false),
                    EditedById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumReplyHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumReplyHistory_ForumReply_ReplyId",
                        column: x => x.ReplyId,
                        principalTable: "ForumReply",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumReplyHistory_User_EditedById",
                        column: x => x.EditedById,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UpvoteForumReply",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ReplyId = table.Column<int>(type: "int", nullable: false),
                    ForumReplyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpvoteForumReply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpvoteForumReply_ForumReply_ForumReplyId",
                        column: x => x.ForumReplyId,
                        principalTable: "ForumReply",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UpvoteForumReply_ForumReply_ReplyId",
                        column: x => x.ReplyId,
                        principalTable: "ForumReply",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpvoteForumReply_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_UserId",
                table: "Account",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorReview_ActorId",
                table: "ActorReview",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorReview_ActorId1",
                table: "ActorReview",
                column: "ActorId1");

            migrationBuilder.CreateIndex(
                name: "IX_ActorReview_UserId",
                table: "ActorReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_PostId",
                table: "Attachment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_UserId",
                table: "Attachment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Avatar_UserId",
                table: "Avatar",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CastMovie_ActorId",
                table: "CastMovie",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_CastMovie_MovieId",
                table: "CastMovie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_CastSerie_ActorId",
                table: "CastSerie",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_CastSerie_SerieId",
                table: "CastSerie",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentChangeLog_UserId",
                table: "ContentChangeLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentHistory_UserId",
                table: "ContentHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CrewMovie_CrewId",
                table: "CrewMovie",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_CrewMovie_MovieId",
                table: "CrewMovie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_CrewReview_CrewId",
                table: "CrewReview",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_CrewReview_CrewId1",
                table: "CrewReview",
                column: "CrewId1");

            migrationBuilder.CreateIndex(
                name: "IX_CrewReview_UserId",
                table: "CrewReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CrewSerie_CrewId",
                table: "CrewSerie",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_CrewSerie_SerieId",
                table: "CrewSerie",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteActorReview_ActorId",
                table: "DownvoteActorReview",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteActorReview_ActorReviewId",
                table: "DownvoteActorReview",
                column: "ActorReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteActorReview_UserId",
                table: "DownvoteActorReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteCrewReview_CrewId",
                table: "DownvoteCrewReview",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteCrewReview_CrewReviewId",
                table: "DownvoteCrewReview",
                column: "CrewReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteCrewReview_UserId",
                table: "DownvoteCrewReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteEpisodeReview_EpisodeId",
                table: "DownvoteEpisodeReview",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteEpisodeReview_EpisodeReviewId",
                table: "DownvoteEpisodeReview",
                column: "EpisodeReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteEpisodeReview_UserId",
                table: "DownvoteEpisodeReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumPost_ForumPostId",
                table: "DownvoteForumPost",
                column: "ForumPostId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumPost_PostId",
                table: "DownvoteForumPost",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumPost_UserId",
                table: "DownvoteForumPost",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumReply_ForumReplyId",
                table: "DownvoteForumReply",
                column: "ForumReplyId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumReply_ReplyId",
                table: "DownvoteForumReply",
                column: "ReplyId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumReply_UserId",
                table: "DownvoteForumReply",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumTopic_ForumTopicId",
                table: "DownvoteForumTopic",
                column: "ForumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumTopic_TopicId",
                table: "DownvoteForumTopic",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteForumTopic_UserId",
                table: "DownvoteForumTopic",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteMovieReview_MovieId",
                table: "DownvoteMovieReview",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteMovieReview_MovieReviewId",
                table: "DownvoteMovieReview",
                column: "MovieReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteMovieReview_UserId",
                table: "DownvoteMovieReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteSeasonReview_SeasonId",
                table: "DownvoteSeasonReview",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteSeasonReview_SeasonReviewId",
                table: "DownvoteSeasonReview",
                column: "SeasonReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteSeasonReview_UserId",
                table: "DownvoteSeasonReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteSerieReview_SerieId",
                table: "DownvoteSerieReview",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteSerieReview_SerieReviewId",
                table: "DownvoteSerieReview",
                column: "SerieReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteSerieReview_UserId",
                table: "DownvoteSerieReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Episode_SeasonId",
                table: "Episode",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeReview_EpisodeId",
                table: "EpisodeReview",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeReview_EpisodeId1",
                table: "EpisodeReview",
                column: "EpisodeId1");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeReview_UserId",
                table: "EpisodeReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumCategory_LastPostId",
                table: "ForumCategory",
                column: "LastPostId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumLogHistory_CategoryId",
                table: "ForumLogHistory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumLogHistory_PostId",
                table: "ForumLogHistory",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumLogHistory_TopicId",
                table: "ForumLogHistory",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumLogHistory_UserId",
                table: "ForumLogHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPost_AnsweredById",
                table: "ForumPost",
                column: "AnsweredById");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPost_DeletedById",
                table: "ForumPost",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPost_ForumCategoryId",
                table: "ForumPost",
                column: "ForumCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPost_TopicId",
                table: "ForumPost",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPost_UserId",
                table: "ForumPost",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPostHistory_EditedById",
                table: "ForumPostHistory",
                column: "EditedById");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPostHistory_PostId",
                table: "ForumPostHistory",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumReply_PostId",
                table: "ForumReply",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumReply_UserId",
                table: "ForumReply",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumReplyHistory_EditedById",
                table: "ForumReplyHistory",
                column: "EditedById");

            migrationBuilder.CreateIndex(
                name: "IX_ForumReplyHistory_ReplyId",
                table: "ForumReplyHistory",
                column: "ReplyId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTagForumTopic_TopicsId",
                table: "ForumTagForumTopic",
                column: "TopicsId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_CategoryId",
                table: "ForumTopic",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_ClosedById",
                table: "ForumTopic",
                column: "ClosedById");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_ForumCategoryId",
                table: "ForumTopic",
                column: "ForumCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopic_UserId",
                table: "ForumTopic",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumUserStats_UserId",
                table: "ForumUserStats",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ForumUserStats_UserId1",
                table: "ForumUserStats",
                column: "UserId1",
                unique: true,
                filter: "[UserId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_List_UserId",
                table: "List",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_List_UserId1",
                table: "List",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ListActor_ActorId",
                table: "ListActor",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ListActor_ListId",
                table: "ListActor",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_ListCrew_CrewId",
                table: "ListCrew",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_ListCrew_ListId",
                table: "ListCrew",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_ListEpisode_EpisodeId",
                table: "ListEpisode",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ListEpisode_ListId",
                table: "ListEpisode",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_ListMovie_ListId",
                table: "ListMovie",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_ListMovie_MovieId",
                table: "ListMovie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ListSeason_ListId",
                table: "ListSeason",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_ListSeason_SeasonId",
                table: "ListSeason",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_ListSerie_ListId",
                table: "ListSerie",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_ListSerie_SerieId",
                table: "ListSerie",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_InboxId",
                table: "Message",
                column: "InboxId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_InboxId1",
                table: "Message",
                column: "InboxId1");

            migrationBuilder.CreateIndex(
                name: "IX_Message_ReceiverId",
                table: "Message",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_SenderId",
                table: "Message",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserId",
                table: "Message",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenre_GenreId",
                table: "MovieGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenre_MovieId",
                table: "MovieGenre",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieReview_MovieId",
                table: "MovieReview",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieReview_MovieId1",
                table: "MovieReview",
                column: "MovieId1");

            migrationBuilder.CreateIndex(
                name: "IX_MovieReview_UserId",
                table: "MovieReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUser_NotificationId",
                table: "NotificationUser",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUser_UserId",
                table: "NotificationUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Season_SerieId",
                table: "Season",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonReview_SeasonId",
                table: "SeasonReview",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonReview_SeasonId1",
                table: "SeasonReview",
                column: "SeasonId1");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonReview_UserId",
                table: "SeasonReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SerieGenre_GenreId",
                table: "SerieGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_SerieGenre_SerieId",
                table: "SerieGenre",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_SerieReview_SerieId",
                table: "SerieReview",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_SerieReview_SerieId1",
                table: "SerieReview",
                column: "SerieId1");

            migrationBuilder.CreateIndex(
                name: "IX_SerieReview_UserId",
                table: "SerieReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Session_UserId",
                table: "Session",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteActorReview_ActorId",
                table: "UpvoteActorReview",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteActorReview_ActorReviewId",
                table: "UpvoteActorReview",
                column: "ActorReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteActorReview_UserId",
                table: "UpvoteActorReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteCrewReview_CrewId",
                table: "UpvoteCrewReview",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteCrewReview_CrewReviewId",
                table: "UpvoteCrewReview",
                column: "CrewReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteCrewReview_UserId",
                table: "UpvoteCrewReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteEpisodeReview_EpisodeId",
                table: "UpvoteEpisodeReview",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteEpisodeReview_EpisodeReviewId",
                table: "UpvoteEpisodeReview",
                column: "EpisodeReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteEpisodeReview_UserId",
                table: "UpvoteEpisodeReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumPost_ForumPostId",
                table: "UpvoteForumPost",
                column: "ForumPostId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumPost_PostId",
                table: "UpvoteForumPost",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumPost_UserId",
                table: "UpvoteForumPost",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumReply_ForumReplyId",
                table: "UpvoteForumReply",
                column: "ForumReplyId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumReply_ReplyId",
                table: "UpvoteForumReply",
                column: "ReplyId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumReply_UserId",
                table: "UpvoteForumReply",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumTopic_ForumTopicId",
                table: "UpvoteForumTopic",
                column: "ForumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumTopic_TopicId",
                table: "UpvoteForumTopic",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteForumTopic_UserId",
                table: "UpvoteForumTopic",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteMovieReview_MovieId",
                table: "UpvoteMovieReview",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteMovieReview_MovieReviewId",
                table: "UpvoteMovieReview",
                column: "MovieReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteMovieReview_UserId",
                table: "UpvoteMovieReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteSeasonReview_SeasonId",
                table: "UpvoteSeasonReview",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteSeasonReview_SeasonReviewId",
                table: "UpvoteSeasonReview",
                column: "SeasonReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteSeasonReview_UserId",
                table: "UpvoteSeasonReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteSerieReview_SerieId",
                table: "UpvoteSerieReview",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteSerieReview_SerieReviewId",
                table: "UpvoteSerieReview",
                column: "SerieReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteSerieReview_UserId",
                table: "UpvoteSerieReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserName",
                table: "User",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserActivity_UserId",
                table: "UserActivity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActorFavorite_ActorId",
                table: "UserActorFavorite",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActorFavorite_UserId",
                table: "UserActorFavorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActorRating_ActorId",
                table: "UserActorRating",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActorRating_UserId",
                table: "UserActorRating",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBadge_RankId",
                table: "UserBadge",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBadge_UserId",
                table: "UserBadge",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBadge_UserId1",
                table: "UserBadge",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserBlock_BlockedId",
                table: "UserBlock",
                column: "BlockedId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBlock_BlockerId",
                table: "UserBlock",
                column: "BlockerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBlock_UserId",
                table: "UserBlock",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBlock_UserId1",
                table: "UserBlock",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserContact_UserId",
                table: "UserContact",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCrewFavorite_CrewId",
                table: "UserCrewFavorite",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCrewFavorite_UserId",
                table: "UserCrewFavorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCrewRating_CrewId",
                table: "UserCrewRating",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCrewRating_UserId",
                table: "UserCrewRating",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeFavorite_EpisodeId",
                table: "UserEpisodeFavorite",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeFavorite_EpisodeId1",
                table: "UserEpisodeFavorite",
                column: "EpisodeId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeFavorite_UserId",
                table: "UserEpisodeFavorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeFavorite_UserId1",
                table: "UserEpisodeFavorite",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeRating_EpisodeId",
                table: "UserEpisodeRating",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeRating_EpisodeId1",
                table: "UserEpisodeRating",
                column: "EpisodeId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeRating_UserId",
                table: "UserEpisodeRating",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeRating_UserId1",
                table: "UserEpisodeRating",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollow_FollowerId",
                table: "UserFollow",
                column: "FollowerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollow_FollowingId",
                table: "UserFollow",
                column: "FollowingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollow_UserId",
                table: "UserFollow",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollow_UserId1",
                table: "UserFollow",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserForumModerator_CategoryId",
                table: "UserForumModerator",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserForumModerator_ForumCategoryId",
                table: "UserForumModerator",
                column: "ForumCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserForumModerator_UserId",
                table: "UserForumModerator",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserForumModerator_UserId1",
                table: "UserForumModerator",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicFavorite_ForumTopicId",
                table: "UserForumTopicFavorite",
                column: "ForumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicFavorite_TopicId",
                table: "UserForumTopicFavorite",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicFavorite_UserId",
                table: "UserForumTopicFavorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicFavorite_UserId1",
                table: "UserForumTopicFavorite",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicWatch_ForumTopicId",
                table: "UserForumTopicWatch",
                column: "ForumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicWatch_TopicId",
                table: "UserForumTopicWatch",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicWatch_UserId",
                table: "UserForumTopicWatch",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserForumTopicWatch_UserId1",
                table: "UserForumTopicWatch",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserGenreFavorite_GenreId",
                table: "UserGenreFavorite",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGenreFavorite_UserId",
                table: "UserGenreFavorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInbox_InboxId",
                table: "UserInbox",
                column: "InboxId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInbox_InboxId1",
                table: "UserInbox",
                column: "InboxId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserInbox_UserId",
                table: "UserInbox",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInbox_UserId1",
                table: "UserInbox",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserMovieFavorite_MovieId",
                table: "UserMovieFavorite",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMovieFavorite_UserId_MovieId",
                table: "UserMovieFavorite",
                columns: new[] { "UserId", "MovieId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserMovieRating_MovieId",
                table: "UserMovieRating",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMovieRating_UserId",
                table: "UserMovieRating",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMute_ModeratorId",
                table: "UserMute",
                column: "ModeratorId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMute_MutedUserId",
                table: "UserMute",
                column: "MutedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMute_UserId",
                table: "UserMute",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMute_UserId1",
                table: "UserMute",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotificationSettings_UserId",
                table: "UserNotificationSettings",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserReport_ModeratorId",
                table: "UserReport",
                column: "ModeratorId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReport_ReportedUserId",
                table: "UserReport",
                column: "ReportedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReport_ReporterId",
                table: "UserReport",
                column: "ReporterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSeasonFavorite_SeasonId",
                table: "UserSeasonFavorite",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSeasonFavorite_UserId",
                table: "UserSeasonFavorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSeasonRating_SeasonId",
                table: "UserSeasonRating",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSeasonRating_UserId",
                table: "UserSeasonRating",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSerieFavorite_SerieId",
                table: "UserSerieFavorite",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSerieFavorite_UserId_SerieId",
                table: "UserSerieFavorite",
                columns: new[] { "UserId", "SerieId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSerieRating_SerieId",
                table: "UserSerieRating",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSerieRating_UserId",
                table: "UserSerieRating",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_ForumPost_PostId",
                table: "Attachment",
                column: "PostId",
                principalTable: "ForumPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteForumPost_ForumPost_ForumPostId",
                table: "DownvoteForumPost",
                column: "ForumPostId",
                principalTable: "ForumPost",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteForumPost_ForumPost_PostId",
                table: "DownvoteForumPost",
                column: "PostId",
                principalTable: "ForumPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteForumReply_ForumReply_ForumReplyId",
                table: "DownvoteForumReply",
                column: "ForumReplyId",
                principalTable: "ForumReply",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteForumReply_ForumReply_ReplyId",
                table: "DownvoteForumReply",
                column: "ReplyId",
                principalTable: "ForumReply",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteForumTopic_ForumTopic_ForumTopicId",
                table: "DownvoteForumTopic",
                column: "ForumTopicId",
                principalTable: "ForumTopic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteForumTopic_ForumTopic_TopicId",
                table: "DownvoteForumTopic",
                column: "TopicId",
                principalTable: "ForumTopic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumCategory_ForumPost_LastPostId",
                table: "ForumCategory",
                column: "LastPostId",
                principalTable: "ForumPost",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumPost_User_AnsweredById",
                table: "ForumPost");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumPost_User_DeletedById",
                table: "ForumPost");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumPost_User_UserId",
                table: "ForumPost");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumTopic_User_ClosedById",
                table: "ForumTopic");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumTopic_User_UserId",
                table: "ForumTopic");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumCategory_ForumPost_LastPostId",
                table: "ForumCategory");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "Avatar");

            migrationBuilder.DropTable(
                name: "CastMovie");

            migrationBuilder.DropTable(
                name: "CastSerie");

            migrationBuilder.DropTable(
                name: "ContentChangeLog");

            migrationBuilder.DropTable(
                name: "ContentHistory");

            migrationBuilder.DropTable(
                name: "CrewMovie");

            migrationBuilder.DropTable(
                name: "CrewSerie");

            migrationBuilder.DropTable(
                name: "DownvoteActorReview");

            migrationBuilder.DropTable(
                name: "DownvoteCrewReview");

            migrationBuilder.DropTable(
                name: "DownvoteEpisodeReview");

            migrationBuilder.DropTable(
                name: "DownvoteForumPost");

            migrationBuilder.DropTable(
                name: "DownvoteForumReply");

            migrationBuilder.DropTable(
                name: "DownvoteForumTopic");

            migrationBuilder.DropTable(
                name: "DownvoteMovieReview");

            migrationBuilder.DropTable(
                name: "DownvoteSeasonReview");

            migrationBuilder.DropTable(
                name: "DownvoteSerieReview");

            migrationBuilder.DropTable(
                name: "ForumLogHistory");

            migrationBuilder.DropTable(
                name: "ForumPostHistory");

            migrationBuilder.DropTable(
                name: "ForumReplyHistory");

            migrationBuilder.DropTable(
                name: "ForumTagForumTopic");

            migrationBuilder.DropTable(
                name: "ForumUserStats");

            migrationBuilder.DropTable(
                name: "ListActor");

            migrationBuilder.DropTable(
                name: "ListCrew");

            migrationBuilder.DropTable(
                name: "ListEpisode");

            migrationBuilder.DropTable(
                name: "ListMovie");

            migrationBuilder.DropTable(
                name: "ListSeason");

            migrationBuilder.DropTable(
                name: "ListSerie");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "MovieGenre");

            migrationBuilder.DropTable(
                name: "NotificationUser");

            migrationBuilder.DropTable(
                name: "SerieGenre");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "UpvoteActorReview");

            migrationBuilder.DropTable(
                name: "UpvoteCrewReview");

            migrationBuilder.DropTable(
                name: "UpvoteEpisodeReview");

            migrationBuilder.DropTable(
                name: "UpvoteForumPost");

            migrationBuilder.DropTable(
                name: "UpvoteForumReply");

            migrationBuilder.DropTable(
                name: "UpvoteForumTopic");

            migrationBuilder.DropTable(
                name: "UpvoteMovieReview");

            migrationBuilder.DropTable(
                name: "UpvoteSeasonReview");

            migrationBuilder.DropTable(
                name: "UpvoteSerieReview");

            migrationBuilder.DropTable(
                name: "UserActivity");

            migrationBuilder.DropTable(
                name: "UserActorFavorite");

            migrationBuilder.DropTable(
                name: "UserActorRating");

            migrationBuilder.DropTable(
                name: "UserBadge");

            migrationBuilder.DropTable(
                name: "UserBlock");

            migrationBuilder.DropTable(
                name: "UserContact");

            migrationBuilder.DropTable(
                name: "UserCrewFavorite");

            migrationBuilder.DropTable(
                name: "UserCrewRating");

            migrationBuilder.DropTable(
                name: "UserEpisodeFavorite");

            migrationBuilder.DropTable(
                name: "UserEpisodeRating");

            migrationBuilder.DropTable(
                name: "UserFollow");

            migrationBuilder.DropTable(
                name: "UserForumModerator");

            migrationBuilder.DropTable(
                name: "UserForumTopicFavorite");

            migrationBuilder.DropTable(
                name: "UserForumTopicWatch");

            migrationBuilder.DropTable(
                name: "UserGenreFavorite");

            migrationBuilder.DropTable(
                name: "UserInbox");

            migrationBuilder.DropTable(
                name: "UserMovieFavorite");

            migrationBuilder.DropTable(
                name: "UserMovieRating");

            migrationBuilder.DropTable(
                name: "UserMute");

            migrationBuilder.DropTable(
                name: "UserNotificationSettings");

            migrationBuilder.DropTable(
                name: "UserReport");

            migrationBuilder.DropTable(
                name: "UserSeasonFavorite");

            migrationBuilder.DropTable(
                name: "UserSeasonRating");

            migrationBuilder.DropTable(
                name: "UserSerieFavorite");

            migrationBuilder.DropTable(
                name: "UserSerieRating");

            migrationBuilder.DropTable(
                name: "ForumTag");

            migrationBuilder.DropTable(
                name: "List");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "ActorReview");

            migrationBuilder.DropTable(
                name: "CrewReview");

            migrationBuilder.DropTable(
                name: "EpisodeReview");

            migrationBuilder.DropTable(
                name: "ForumReply");

            migrationBuilder.DropTable(
                name: "MovieReview");

            migrationBuilder.DropTable(
                name: "SeasonReview");

            migrationBuilder.DropTable(
                name: "SerieReview");

            migrationBuilder.DropTable(
                name: "UserRank");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Inbox");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "Crew");

            migrationBuilder.DropTable(
                name: "Episode");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Season");

            migrationBuilder.DropTable(
                name: "Serie");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ForumPost");

            migrationBuilder.DropTable(
                name: "ForumTopic");

            migrationBuilder.DropTable(
                name: "ForumCategory");
        }
    }
}
