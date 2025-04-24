IF NOT EXISTS (
    SELECT
        1
    FROM
        Genre
) BEGIN
SET
    IDENTITY_INSERT Genre ON;

INSERT INTO
    Genre (Id, Name)
VALUES
    (1, 'Action'),
    (2, 'Asian'),
    (3, 'Crime'),
    (4, 'Netflix'),
    (5, 'Horror'),
    (6, 'Thriller'),
    (7, 'Fantasy'),
    (8, 'Sci-Fi'),
    (9, 'Drama'),
    (10, 'Spanish'),
    (11, 'Adventure'),
    (12, 'Comedy'),
    (13, 'History'),
    (14, 'War'),
    (15, 'Russian'),
    (16, 'Romance'),
    (17, 'Biography'),
    (18, 'Italian'),
    (19, 'Mystery'),
    (20, 'Sport'),
    (21, 'Family'),
    (22, 'Music'),
    (23, 'Animation'),
    (24, 'Erotic +18'),
    (25, 'Nordic'),
    (26, 'Documentary'),
    (27, 'Turkish'),
    (28, 'COMING SOON'),
    (29, 'German'),
    (30, 'French'),
    (31, 'Hindi');

SET
    IDENTITY_INSERT Genre OFF;

END