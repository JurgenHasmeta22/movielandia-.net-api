IF NOT EXISTS (
    SELECT
        1
    FROM
        SerieGenre
) BEGIN
SET
    IDENTITY_INSERT SerieGenre ON;

INSERT INTO
    SerieGenre (Id, SerieId, GenreId)
VALUES
    (1, 1, 1), -- Serie 1: Action
    (2, 1, 2), -- Serie 1: Asian
    (3, 1, 3), -- Serie 1: Crime
    (4, 2, 4), -- Serie 2: Netflix
    (5, 2, 5), -- Serie 2: Horror
    (6, 3, 6), -- Serie 3: Thriller
    (7, 3, 7), -- Serie 3: Fantasy
    (8, 5, 8), -- Serie 5: Sci-Fi
    (9, 4, 9), -- Serie 4: Drama
    (10, 6, 10), -- Serie 6: Spanish
    (11, 6, 11), -- Serie 6: Adventure
    (12, 6, 12), -- Serie 6: Comedy
    (13, 6, 13), -- Serie 6: History
    (14, 7, 14), -- Serie 7: War
    (15, 7, 15), -- Serie 7: Russian
    (16, 7, 16), -- Serie 7: Romance
    (17, 7, 17), -- Serie 7: Biography
    (18, 8, 18), -- Serie 8: Italian
    (19, 10, 19), -- Serie 10: Mystery
    (20, 9, 20), -- Serie 9: Sport
    (21, 11, 21), -- Serie 11: Family
    (22, 12, 22), -- Serie 12: Music
    (23, 13, 23), -- Serie 13: Animation
    (24, 14, 24), -- Serie 14: Erotic +18
    (25, 15, 25), -- Serie 15: Nordic
    (26, 16, 26), -- Serie 16: Documentary
    (27, 17, 27), -- Serie 17: Turkish
    (28, 18, 28), -- Serie 18: Coming Soon
    (29, 19, 29), -- Serie 19: German
    (30, 19, 30), -- Serie 19: French
    (31, 19, 31), -- Serie 19: Hindi
    (32, 19, 5);

SET
    IDENTITY_INSERT SerieGenre OFF;

END