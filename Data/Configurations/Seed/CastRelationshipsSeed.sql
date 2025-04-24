IF NOT EXISTS (
    SELECT
        1
    FROM
        CastMovie
) BEGIN
SET
    IDENTITY_INSERT CastMovie ON;

INSERT INTO
    CastMovie (Id, MovieId, ActorId)
VALUES
    -- Movie 1 cast
    (1, 1, 11),
    (2, 1, 12),
    (3, 1, 13),
    -- Movie 2 cast
    (4, 2, 14),
    (5, 2, 15),
    (6, 2, 16),
    -- Movie 3 cast
    (7, 3, 17),
    (8, 3, 18),
    (9, 3, 19),
    -- Movie 4 cast
    (10, 4, 20),
    (11, 4, 21),
    (12, 4, 22),
    -- Movie 5 cast
    (13, 5, 1),
    (14, 5, 2),
    (15, 5, 3),
    (16, 5, 4),
    (17, 5, 5),
    (18, 5, 6),
    (19, 5, 7),
    -- Movie 6-8 cast
    (20, 6, 23),
    (21, 6, 24),
    (22, 6, 25),
    (23, 8, 26),
    (24, 8, 27),
    (25, 8, 28),
    -- Additional cast relationships for actor 1
    (26, 1, 1),
    (27, 2, 1),
    (28, 3, 1),
    (29, 4, 1),
    (30, 6, 1),
    (31, 7, 1);

SET
    IDENTITY_INSERT CastMovie OFF;

END
IF NOT EXISTS (
    SELECT
        1
    FROM
        CastSerie
) BEGIN
SET
    IDENTITY_INSERT CastSerie ON;

INSERT INTO
    CastSerie (Id, SerieId, ActorId)
VALUES
    -- Series 1 cast
    (1, 1, 41),
    (2, 1, 42),
    (3, 1, 43),
    (4, 1, 1),
    (5, 1, 2),
    (6, 1, 3),
    (7, 1, 4),
    (8, 1, 5),
    (9, 1, 6),
    (10, 1, 7),
    -- Series 2-4 cast
    (11, 2, 9),
    (12, 2, 10),
    (13, 2, 1),
    (14, 3, 44),
    (15, 3, 45),
    (16, 3, 46),
    (17, 4, 3),
    -- Additional series cast
    (18, 5, 37),
    (19, 5, 38),
    (20, 5, 39),
    (21, 5, 1),
    -- Actor 1's additional appearances
    (22, 2, 1),
    (23, 3, 1),
    (24, 4, 1),
    (25, 5, 1),
    (26, 6, 1),
    (27, 7, 1);

SET
    IDENTITY_INSERT CastSerie OFF;

END