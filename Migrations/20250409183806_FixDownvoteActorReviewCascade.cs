using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movielandia_.net_api.Migrations
{
    /// <inheritdoc />
    public partial class FixDownvoteActorReviewCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteActorReviews_ActorReviews_ActorReviewId",
                table: "DownvoteActorReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteActorReviews_Users_UserId",
                table: "DownvoteActorReviews"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteActorReviews_ActorReviews_ActorReviewId",
                table: "DownvoteActorReviews",
                column: "ActorReviewId",
                principalTable: "ActorReviews",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteActorReviews_Users_UserId",
                table: "DownvoteActorReviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteActorReviews_ActorReviews_ActorReviewId",
                table: "DownvoteActorReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteActorReviews_Users_UserId",
                table: "DownvoteActorReviews"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteActorReviews_ActorReviews_ActorReviewId",
                table: "DownvoteActorReviews",
                column: "ActorReviewId",
                principalTable: "ActorReviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteActorReviews_Users_UserId",
                table: "DownvoteActorReviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );
        }
    }
}
