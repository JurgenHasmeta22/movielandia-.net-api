IF NOT EXISTS (
    SELECT
        1
    FROM
        MovieGenre
) BEGIN
SET
    IDENTITY_INSERT MovieGenre ON;

INSERT INTO
    MovieGenre (Id, MovieId, GenreId)
VALUES
    (1, 1, 1), -- Movie 1: Action
    (2, 1, 2), -- Movie 1: Asian
    (3, 2, 3), -- Movie 2: Crime
    (4, 2, 4), -- Movie 2: Netflix
    (5, 2, 5), -- Movie 2: Horror
    (6, 3, 6), -- Movie 3: Thriller
    (7, 3, 7), -- Movie 3: Fantasy
    (8, 4, 8), -- Movie 4: Sci-Fi
    (9, 4, 9), -- Movie 4: Drama
    (10, 4, 10), -- Movie 4: Spanish
    (11, 5, 11), -- Movie 5: Adventure
    (12, 5, 12), -- Movie 5: Comedy
    (13, 5, 13), -- Movie 5: History
    (14, 6, 14), -- Movie 6: War
    (15, 6, 15), -- Movie 6: Russian
    (16, 6, 16), -- Movie 6: Romance
    (17, 7, 17), -- Movie 7: Biography
    (18, 7, 18), -- Movie 7: Italian
    (19, 7, 19), -- Movie 7: Mystery
    (20, 8, 20), -- Movie 8: Sport
    (21, 8, 21), -- Movie 8: Family
    (22, 8, 22), -- Movie 8: Music
    (23, 9, 23), -- Movie 9: Animation
    (24, 9, 24), -- Movie 9: Erotic +18
    (25, 10, 25), -- Movie 10: Nordic
    (26, 11, 26), -- Movie 11: Documentary
    (27, 11, 27), -- Movie 11: Turkish
    (28, 11, 28), -- Movie 11: Coming Soon
    (29, 11, 29), -- Movie 11: German
    (30, 12, 30), -- Movie 12: French
    (31, 13, 31), -- Movie 13: Hindi
    (32, 14, 3), -- Movie 14: Crime
    (33, 15, 1), -- Movie 15: Action
    (34, 15, 2), -- Movie 15: Asian
    (35, 15, 3), -- Movie 15: Crime
    (36, 15, 4), -- Movie 15: Netflix
    (37, 15, 5), -- Movie 15: Horror
    (38, 16, 6), -- Movie 16: Thriller
    (39, 16, 7), -- Movie 16: Fantasy
    (40, 16, 8), -- Movie 16: Sci-Fi
    (41, 16, 9), -- Movie 16: Drama
    (42, 16, 10), -- Movie 16: Spanish
    (43, 17, 11), -- Movie 17: Adventure
    (44, 17, 12), -- Movie 17: Comedy
    (45, 18, 13), -- Movie 18: History
    (46, 18, 14), -- Movie 18: War
    (47, 19, 15), -- Movie 19: Russian
    (48, 19, 16), -- Movie 19: Romance
    (49, 19, 17);

SET
    IDENTITY_INSERT MovieGenre OFF;

END