using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movielandia_.net_api.Migrations
{
    /// <inheritdoc />
    public partial class AddedCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteEpisodeReviews_Episodes_EpisodeId",
                table: "DownvoteEpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteEpisodeReviews_Episodes_EpisodeId",
                table: "UpvoteEpisodeReviews"
            );

            migrationBuilder.AddColumn<int>(
                name: "EpisodeId1",
                table: "UserEpisodeRatings",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "UserEpisodeRatings",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "EpisodeId1",
                table: "UserEpisodeFavorites",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "UserEpisodeFavorites",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "EpisodeId1",
                table: "UpvoteEpisodeReviews",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "EpisodeReviewId1",
                table: "UpvoteEpisodeReviews",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "SerieId1",
                table: "SerieReviews",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "SerieId1",
                table: "Seasons",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "SeasonId1",
                table: "SeasonReviews",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "MovieId1",
                table: "MovieReviews",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "SeasonId1",
                table: "Episodes",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "EpisodeId1",
                table: "EpisodeReviews",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "EpisodeReviews",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "EpisodeId1",
                table: "DownvoteEpisodeReviews",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "EpisodeReviewId1",
                table: "DownvoteEpisodeReviews",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "CrewId1",
                table: "CrewReviews",
                type: "int",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "ActorId1",
                table: "ActorReviews",
                type: "int",
                nullable: true
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_Message_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
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
                name: "IX_UserEpisodeRatings_EpisodeId1",
                table: "UserEpisodeRatings",
                column: "EpisodeId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeRatings_UserId1",
                table: "UserEpisodeRatings",
                column: "UserId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeFavorites_EpisodeId1",
                table: "UserEpisodeFavorites",
                column: "EpisodeId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserEpisodeFavorites_UserId1",
                table: "UserEpisodeFavorites",
                column: "UserId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteEpisodeReviews_EpisodeId1",
                table: "UpvoteEpisodeReviews",
                column: "EpisodeId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UpvoteEpisodeReviews_EpisodeReviewId1",
                table: "UpvoteEpisodeReviews",
                column: "EpisodeReviewId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SerieReviews_SerieId1",
                table: "SerieReviews",
                column: "SerieId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_SerieId1",
                table: "Seasons",
                column: "SerieId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SeasonReviews_SeasonId1",
                table: "SeasonReviews",
                column: "SeasonId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_MovieReviews_MovieId1",
                table: "MovieReviews",
                column: "MovieId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_SeasonId1",
                table: "Episodes",
                column: "SeasonId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeReviews_EpisodeId1",
                table: "EpisodeReviews",
                column: "EpisodeId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeReviews_UserId1",
                table: "EpisodeReviews",
                column: "UserId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteEpisodeReviews_EpisodeId1",
                table: "DownvoteEpisodeReviews",
                column: "EpisodeId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteEpisodeReviews_EpisodeReviewId1",
                table: "DownvoteEpisodeReviews",
                column: "EpisodeReviewId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CrewReviews_CrewId1",
                table: "CrewReviews",
                column: "CrewId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ActorReviews_ActorId1",
                table: "ActorReviews",
                column: "ActorId1"
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

            migrationBuilder.AddForeignKey(
                name: "FK_ActorReviews_Actors_ActorId1",
                table: "ActorReviews",
                column: "ActorId1",
                principalTable: "Actors",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_CrewReviews_Crews_CrewId1",
                table: "CrewReviews",
                column: "CrewId1",
                principalTable: "Crews",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteEpisodeReviews_EpisodeReviews_EpisodeReviewId1",
                table: "DownvoteEpisodeReviews",
                column: "EpisodeReviewId1",
                principalTable: "EpisodeReviews",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteEpisodeReviews_Episodes_EpisodeId",
                table: "DownvoteEpisodeReviews",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteEpisodeReviews_Episodes_EpisodeId1",
                table: "DownvoteEpisodeReviews",
                column: "EpisodeId1",
                principalTable: "Episodes",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeReviews_Episodes_EpisodeId1",
                table: "EpisodeReviews",
                column: "EpisodeId1",
                principalTable: "Episodes",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeReviews_Users_UserId1",
                table: "EpisodeReviews",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Seasons_SeasonId1",
                table: "Episodes",
                column: "SeasonId1",
                principalTable: "Seasons",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReviews_Movies_MovieId1",
                table: "MovieReviews",
                column: "MovieId1",
                principalTable: "Movies",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonReviews_Seasons_SeasonId1",
                table: "SeasonReviews",
                column: "SeasonId1",
                principalTable: "Seasons",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Series_SerieId1",
                table: "Seasons",
                column: "SerieId1",
                principalTable: "Series",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_SerieReviews_Series_SerieId1",
                table: "SerieReviews",
                column: "SerieId1",
                principalTable: "Series",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteEpisodeReviews_EpisodeReviews_EpisodeReviewId1",
                table: "UpvoteEpisodeReviews",
                column: "EpisodeReviewId1",
                principalTable: "EpisodeReviews",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteEpisodeReviews_Episodes_EpisodeId",
                table: "UpvoteEpisodeReviews",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteEpisodeReviews_Episodes_EpisodeId1",
                table: "UpvoteEpisodeReviews",
                column: "EpisodeId1",
                principalTable: "Episodes",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserEpisodeFavorites_Episodes_EpisodeId1",
                table: "UserEpisodeFavorites",
                column: "EpisodeId1",
                principalTable: "Episodes",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserEpisodeFavorites_Users_UserId1",
                table: "UserEpisodeFavorites",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserEpisodeRatings_Episodes_EpisodeId1",
                table: "UserEpisodeRatings",
                column: "EpisodeId1",
                principalTable: "Episodes",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserEpisodeRatings_Users_UserId1",
                table: "UserEpisodeRatings",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id"
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
                name: "FK_ActorReviews_Actors_ActorId1",
                table: "ActorReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_CrewReviews_Crews_CrewId1",
                table: "CrewReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteEpisodeReviews_EpisodeReviews_EpisodeReviewId1",
                table: "DownvoteEpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteEpisodeReviews_Episodes_EpisodeId",
                table: "DownvoteEpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteEpisodeReviews_Episodes_EpisodeId1",
                table: "DownvoteEpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeReviews_Episodes_EpisodeId1",
                table: "EpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeReviews_Users_UserId1",
                table: "EpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Seasons_SeasonId1",
                table: "Episodes"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReviews_Movies_MovieId1",
                table: "MovieReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_SeasonReviews_Seasons_SeasonId1",
                table: "SeasonReviews"
            );

            migrationBuilder.DropForeignKey(name: "FK_Seasons_Series_SerieId1", table: "Seasons");

            migrationBuilder.DropForeignKey(
                name: "FK_SerieReviews_Series_SerieId1",
                table: "SerieReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteEpisodeReviews_EpisodeReviews_EpisodeReviewId1",
                table: "UpvoteEpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteEpisodeReviews_Episodes_EpisodeId",
                table: "UpvoteEpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteEpisodeReviews_Episodes_EpisodeId1",
                table: "UpvoteEpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UserEpisodeFavorites_Episodes_EpisodeId1",
                table: "UserEpisodeFavorites"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UserEpisodeFavorites_Users_UserId1",
                table: "UserEpisodeFavorites"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UserEpisodeRatings_Episodes_EpisodeId1",
                table: "UserEpisodeRatings"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UserEpisodeRatings_Users_UserId1",
                table: "UserEpisodeRatings"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_ForumCategory_ForumPost_LastPostId",
                table: "ForumCategory"
            );

            migrationBuilder.DropTable(name: "Attachment");

            migrationBuilder.DropTable(name: "DownvoteForumPost");

            migrationBuilder.DropTable(name: "DownvoteForumReply");

            migrationBuilder.DropTable(name: "DownvoteForumTopic");

            migrationBuilder.DropTable(name: "ForumPostHistory");

            migrationBuilder.DropTable(name: "ForumReplyHistory");

            migrationBuilder.DropTable(name: "ForumTagForumTopic");

            migrationBuilder.DropTable(name: "Message");

            migrationBuilder.DropTable(name: "UpvoteForumPost");

            migrationBuilder.DropTable(name: "UpvoteForumReply");

            migrationBuilder.DropTable(name: "UpvoteForumTopic");

            migrationBuilder.DropTable(name: "UserForumModerator");

            migrationBuilder.DropTable(name: "UserForumTopicFavorite");

            migrationBuilder.DropTable(name: "UserForumTopicWatch");

            migrationBuilder.DropTable(name: "UserInbox");

            migrationBuilder.DropTable(name: "ForumTag");

            migrationBuilder.DropTable(name: "ForumReply");

            migrationBuilder.DropTable(name: "Inbox");

            migrationBuilder.DropTable(name: "ForumPost");

            migrationBuilder.DropTable(name: "ForumTopic");

            migrationBuilder.DropTable(name: "ForumCategory");

            migrationBuilder.DropIndex(
                name: "IX_UserEpisodeRatings_EpisodeId1",
                table: "UserEpisodeRatings"
            );

            migrationBuilder.DropIndex(
                name: "IX_UserEpisodeRatings_UserId1",
                table: "UserEpisodeRatings"
            );

            migrationBuilder.DropIndex(
                name: "IX_UserEpisodeFavorites_EpisodeId1",
                table: "UserEpisodeFavorites"
            );

            migrationBuilder.DropIndex(
                name: "IX_UserEpisodeFavorites_UserId1",
                table: "UserEpisodeFavorites"
            );

            migrationBuilder.DropIndex(
                name: "IX_UpvoteEpisodeReviews_EpisodeId1",
                table: "UpvoteEpisodeReviews"
            );

            migrationBuilder.DropIndex(
                name: "IX_UpvoteEpisodeReviews_EpisodeReviewId1",
                table: "UpvoteEpisodeReviews"
            );

            migrationBuilder.DropIndex(name: "IX_SerieReviews_SerieId1", table: "SerieReviews");

            migrationBuilder.DropIndex(name: "IX_Seasons_SerieId1", table: "Seasons");

            migrationBuilder.DropIndex(name: "IX_SeasonReviews_SeasonId1", table: "SeasonReviews");

            migrationBuilder.DropIndex(name: "IX_MovieReviews_MovieId1", table: "MovieReviews");

            migrationBuilder.DropIndex(name: "IX_Episodes_SeasonId1", table: "Episodes");

            migrationBuilder.DropIndex(
                name: "IX_EpisodeReviews_EpisodeId1",
                table: "EpisodeReviews"
            );

            migrationBuilder.DropIndex(name: "IX_EpisodeReviews_UserId1", table: "EpisodeReviews");

            migrationBuilder.DropIndex(
                name: "IX_DownvoteEpisodeReviews_EpisodeId1",
                table: "DownvoteEpisodeReviews"
            );

            migrationBuilder.DropIndex(
                name: "IX_DownvoteEpisodeReviews_EpisodeReviewId1",
                table: "DownvoteEpisodeReviews"
            );

            migrationBuilder.DropIndex(name: "IX_CrewReviews_CrewId1", table: "CrewReviews");

            migrationBuilder.DropIndex(name: "IX_ActorReviews_ActorId1", table: "ActorReviews");

            migrationBuilder.DropColumn(name: "EpisodeId1", table: "UserEpisodeRatings");

            migrationBuilder.DropColumn(name: "UserId1", table: "UserEpisodeRatings");

            migrationBuilder.DropColumn(name: "EpisodeId1", table: "UserEpisodeFavorites");

            migrationBuilder.DropColumn(name: "UserId1", table: "UserEpisodeFavorites");

            migrationBuilder.DropColumn(name: "EpisodeId1", table: "UpvoteEpisodeReviews");

            migrationBuilder.DropColumn(name: "EpisodeReviewId1", table: "UpvoteEpisodeReviews");

            migrationBuilder.DropColumn(name: "SerieId1", table: "SerieReviews");

            migrationBuilder.DropColumn(name: "SerieId1", table: "Seasons");

            migrationBuilder.DropColumn(name: "SeasonId1", table: "SeasonReviews");

            migrationBuilder.DropColumn(name: "MovieId1", table: "MovieReviews");

            migrationBuilder.DropColumn(name: "SeasonId1", table: "Episodes");

            migrationBuilder.DropColumn(name: "EpisodeId1", table: "EpisodeReviews");

            migrationBuilder.DropColumn(name: "UserId1", table: "EpisodeReviews");

            migrationBuilder.DropColumn(name: "EpisodeId1", table: "DownvoteEpisodeReviews");

            migrationBuilder.DropColumn(name: "EpisodeReviewId1", table: "DownvoteEpisodeReviews");

            migrationBuilder.DropColumn(name: "CrewId1", table: "CrewReviews");

            migrationBuilder.DropColumn(name: "ActorId1", table: "ActorReviews");

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteEpisodeReviews_Episodes_EpisodeId",
                table: "DownvoteEpisodeReviews",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteEpisodeReviews_Episodes_EpisodeId",
                table: "UpvoteEpisodeReviews",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );
        }
    }
}
