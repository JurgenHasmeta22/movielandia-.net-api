using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movielandia_.net_api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatCascadeMoreStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteCrewReviews_Crews_CrewId",
                table: "DownvoteCrewReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteEpisodeReviews_EpisodeReviews_EpisodeReviewId1",
                table: "DownvoteEpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteEpisodeReviews_Episodes_EpisodeId1",
                table: "DownvoteEpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteMovieReviews_Movies_MovieId",
                table: "DownvoteMovieReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteSeasonReviews_Seasons_SeasonId",
                table: "DownvoteSeasonReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteSerieReviews_Series_SerieId",
                table: "DownvoteSerieReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteCrewReviews_Crews_CrewId",
                table: "UpvoteCrewReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteEpisodeReviews_EpisodeReviews_EpisodeReviewId1",
                table: "UpvoteEpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteEpisodeReviews_Episodes_EpisodeId1",
                table: "UpvoteEpisodeReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteMovieReviews_Movies_MovieId",
                table: "UpvoteMovieReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteSeasonReviews_Seasons_SeasonId",
                table: "UpvoteSeasonReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteSerieReviews_Series_SerieId",
                table: "UpvoteSerieReviews"
            );

            migrationBuilder.DropIndex(
                name: "IX_UpvoteEpisodeReviews_EpisodeId1",
                table: "UpvoteEpisodeReviews"
            );

            migrationBuilder.DropIndex(
                name: "IX_UpvoteEpisodeReviews_EpisodeReviewId1",
                table: "UpvoteEpisodeReviews"
            );

            migrationBuilder.DropIndex(
                name: "IX_DownvoteEpisodeReviews_EpisodeId1",
                table: "DownvoteEpisodeReviews"
            );

            migrationBuilder.DropIndex(
                name: "IX_DownvoteEpisodeReviews_EpisodeReviewId1",
                table: "DownvoteEpisodeReviews"
            );

            migrationBuilder.DropColumn(name: "EpisodeId1", table: "UpvoteEpisodeReviews");

            migrationBuilder.DropColumn(name: "EpisodeReviewId1", table: "UpvoteEpisodeReviews");

            migrationBuilder.DropColumn(name: "EpisodeId1", table: "DownvoteEpisodeReviews");

            migrationBuilder.DropColumn(name: "EpisodeReviewId1", table: "DownvoteEpisodeReviews");

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteCrewReviews_Crews_CrewId",
                table: "DownvoteCrewReviews",
                column: "CrewId",
                principalTable: "Crews",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteMovieReviews_Movies_MovieId",
                table: "DownvoteMovieReviews",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteSeasonReviews_Seasons_SeasonId",
                table: "DownvoteSeasonReviews",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteSerieReviews_Series_SerieId",
                table: "DownvoteSerieReviews",
                column: "SerieId",
                principalTable: "Series",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteCrewReviews_Crews_CrewId",
                table: "UpvoteCrewReviews",
                column: "CrewId",
                principalTable: "Crews",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteMovieReviews_Movies_MovieId",
                table: "UpvoteMovieReviews",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteSeasonReviews_Seasons_SeasonId",
                table: "UpvoteSeasonReviews",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteSerieReviews_Series_SerieId",
                table: "UpvoteSerieReviews",
                column: "SerieId",
                principalTable: "Series",
                principalColumn: "Id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteCrewReviews_Crews_CrewId",
                table: "DownvoteCrewReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteMovieReviews_Movies_MovieId",
                table: "DownvoteMovieReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteSeasonReviews_Seasons_SeasonId",
                table: "DownvoteSeasonReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_DownvoteSerieReviews_Series_SerieId",
                table: "DownvoteSerieReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteCrewReviews_Crews_CrewId",
                table: "UpvoteCrewReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteMovieReviews_Movies_MovieId",
                table: "UpvoteMovieReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteSeasonReviews_Seasons_SeasonId",
                table: "UpvoteSeasonReviews"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UpvoteSerieReviews_Series_SerieId",
                table: "UpvoteSerieReviews"
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
                name: "IX_DownvoteEpisodeReviews_EpisodeId1",
                table: "DownvoteEpisodeReviews",
                column: "EpisodeId1"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DownvoteEpisodeReviews_EpisodeReviewId1",
                table: "DownvoteEpisodeReviews",
                column: "EpisodeReviewId1"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteCrewReviews_Crews_CrewId",
                table: "DownvoteCrewReviews",
                column: "CrewId",
                principalTable: "Crews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteEpisodeReviews_EpisodeReviews_EpisodeReviewId1",
                table: "DownvoteEpisodeReviews",
                column: "EpisodeReviewId1",
                principalTable: "EpisodeReviews",
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
                name: "FK_DownvoteMovieReviews_Movies_MovieId",
                table: "DownvoteMovieReviews",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteSeasonReviews_Seasons_SeasonId",
                table: "DownvoteSeasonReviews",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_DownvoteSerieReviews_Series_SerieId",
                table: "DownvoteSerieReviews",
                column: "SerieId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteCrewReviews_Crews_CrewId",
                table: "UpvoteCrewReviews",
                column: "CrewId",
                principalTable: "Crews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteEpisodeReviews_EpisodeReviews_EpisodeReviewId1",
                table: "UpvoteEpisodeReviews",
                column: "EpisodeReviewId1",
                principalTable: "EpisodeReviews",
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
                name: "FK_UpvoteMovieReviews_Movies_MovieId",
                table: "UpvoteMovieReviews",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteSeasonReviews_Seasons_SeasonId",
                table: "UpvoteSeasonReviews",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UpvoteSerieReviews_Series_SerieId",
                table: "UpvoteSerieReviews",
                column: "SerieId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );
        }
    }
}
