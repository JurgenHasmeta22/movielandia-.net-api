IF EXISTS (
    SELECT
        1
    FROM
        MovieReview
)
DELETE FROM MovieReview;

IF EXISTS (
    SELECT
        1
    FROM
        CrewReview
)
DELETE FROM CrewReview;

IF EXISTS (
    SELECT
        1
    FROM
        UpvoteMovieReview
)
DELETE FROM UpvoteMovieReview;

IF EXISTS (
    SELECT
        1
    FROM
        DownvoteMovieReview
)
DELETE FROM DownvoteMovieReview;

IF EXISTS (
    SELECT
        1
    FROM
        UpvoteCrewReview
)
DELETE FROM UpvoteCrewReview;

IF EXISTS (
    SELECT
        1
    FROM
        DownvoteCrewReview
)
DELETE FROM DownvoteCrewReview;

SET
    IDENTITY_INSERT MovieReview ON;

INSERT INTO
    MovieReview (Id, Content, Rating, CreatedAt, UserId, MovieId)
VALUES
    (1, 'test', 4.5, GETDATE (), 2, 1),
    (2, 'test', 4.0, GETDATE (), 3, 1),
    (3, 'test', 3.5, GETDATE (), 4, 1),
    (4, 'test', 5.0, GETDATE (), 5, 1),
    (5, 'test', 4.8, GETDATE (), 6, 1),
    (6, 'test', 3.0, GETDATE (), 7, 1),
    (7, 'test', 4.2, GETDATE (), 8, 1);

SET
    IDENTITY_INSERT MovieReview OFF;

SET
    IDENTITY_INSERT UpvoteMovieReview ON;

INSERT INTO
    UpvoteMovieReview (Id, UserId, MovieId, MovieReviewId)
VALUES
    (1, 3, 1, 1), -- test2 upvoted test1's review
    (2, 4, 1, 2), -- test3 upvoted test2's review
    (3, 5, 1, 4), -- test4 upvoted test3's review
    (4, 6, 1, 5), -- test5 upvoted test4's review
    (5, 7, 1, 7), -- test6 upvoted test7's review
    (6, 8, 1, 6), -- test7 upvoted test6's review
    (7, 2, 1, 3);

-- test1 upvoted test3's review
SET
    IDENTITY_INSERT UpvoteMovieReview OFF;

-- Downvote Movie Reviews
SET
    IDENTITY_INSERT DownvoteMovieReview ON;

INSERT INTO
    DownvoteMovieReview (Id, UserId, MovieId, MovieReviewId)
VALUES
    (1, 6, 1, 2), -- test5 downvoted test2's review
    (2, 4, 1, 5);

-- test3 downvoted test5's review
SET
    IDENTITY_INSERT DownvoteMovieReview OFF;

SET
    IDENTITY_INSERT CrewReview ON;

INSERT INTO
    CrewReview (Id, Content, Rating, CreatedAt, UserId, CrewId)
VALUES
    (1, 'test', 4.5, GETDATE (), 2, 1),
    (2, 'test', 4.0, GETDATE (), 3, 1),
    (3, 'test', 3.5, GETDATE (), 4, 1),
    (4, 'test', 5.0, GETDATE (), 5, 1),
    (5, 'test', 5.0, GETDATE (), 6, 1),
    (6, 'test', 3.0, GETDATE (), 7, 1),
    (7, 'test', 4.0, GETDATE (), 8, 1);

SET
    IDENTITY_INSERT CrewReview OFF;

SET
    IDENTITY_INSERT UpvoteCrewReview ON;

INSERT INTO
    UpvoteCrewReview (Id, UserId, CrewId, CrewReviewId)
VALUES
    (1, 3, 1, 1), -- test2 upvoted test1's review
    (2, 4, 1, 2), -- test3 upvoted test2's review
    (3, 5, 1, 4), -- test4 upvoted test3's review
    (4, 6, 1, 5), -- test5 upvoted test4's review
    (5, 7, 1, 7), -- test6 upvoted test7's review
    (6, 8, 1, 6), -- test7 upvoted test6's review
    (7, 2, 1, 3);

-- test1 upvoted test3's review
SET
    IDENTITY_INSERT UpvoteCrewReview OFF;

SET
    IDENTITY_INSERT DownvoteCrewReview ON;

INSERT INTO
    DownvoteCrewReview (Id, UserId, CrewId, CrewReviewId)
VALUES
    (1, 6, 1, 2), -- test5 downvoted test2's review
    (2, 4, 1, 5);

-- test3 downvoted test5's review
SET
    IDENTITY_INSERT DownvoteCrewReview OFF;