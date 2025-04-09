using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movielandia_.net_api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatCascadeAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteActorReviews_Actors_ActorId",
                table: "DownvoteActorReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteActorReviews_Actors_ActorId",
                table: "UpvoteActorReviews"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteActorReviews_Actors_ActorId",
                table: "DownvoteActorReviews",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteActorReviews_Actors_ActorId",
                table: "UpvoteActorReviews",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteActorReviews_Actors_ActorId",
                table: "DownvoteActorReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteActorReviews_Actors_ActorId",
                table: "UpvoteActorReviews"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteActorReviews_Actors_ActorId",
                table: "DownvoteActorReviews",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteActorReviews_Actors_ActorId",
                table: "UpvoteActorReviews",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );
        }
    }
}
