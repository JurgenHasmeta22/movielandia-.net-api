-- Clear tables if there's a specific need to refresh data
-- IF EXISTS (SELECT 1 FROM UserGenreFavorite) DELETE FROM UserGenreFavorite;
-- IF EXISTS (SELECT 1 FROM UserMovieFavorite) DELETE FROM UserMovieFavorite;
-- IF EXISTS (SELECT 1 FROM UserMovieRating) DELETE FROM UserMovieRating;
-- IF EXISTS (SELECT 1 FROM MovieReview) DELETE FROM MovieReview;
-- Genres - Only insert if table is empty
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
    (2, 'Drama'),
    (3, 'Comedy'),
    (4, 'Science Fiction'),
    (5, 'Horror'),
    (6, 'Romance'),
    (7, 'Thriller'),
    (8, 'Documentary'),
    (9, 'Animation'),
    (10, 'Fantasy'),
    (11, 'Adventure'),
    (12, 'Mystery'),
    (13, 'Crime'),
    (14, 'Family'),
    (15, 'War'),
    (16, 'History'),
    (17, 'Western'),
    (18, 'Sport'),
    (19, 'Musical'),
    (20, 'Biography'),
    (21, 'Asian'),
    (22, 'Spanish'),
    (23, 'Russian'),
    (24, 'Italian'),
    (25, 'Nordic'),
    (26, 'Turkish'),
    (27, 'German'),
    (28, 'French'),
    (29, 'Hindi'),
    (30, 'Netflix'),
    (31, 'Erotic +18');

SET
    IDENTITY_INSERT Genre OFF;

END
-- Actors - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        Actor
) BEGIN
SET
    IDENTITY_INSERT Actor ON;

INSERT INTO
    Actor (
        Id,
        Fullname,
        Description,
        Debut,
        PhotoSrc,
        PhotoSrcProd,
        CreatedAt,
        Gender
    )
VALUES
    (
        1,
        'Tom Holland',
        'Thomas Stanley Holland is an English actor. His accolades include a British Academy Film Award and three Saturn Awards.',
        '2012',
        'http://localhost:4000/images/actors/tom-holland.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/actors/tom-holland.jpg',
        '2025-04-10',
        0
    ),
    (
        2,
        'Zendaya',
        'Zendaya Maree Stoermer Coleman is an American actress and singer who has received various accolades.',
        '2010',
        'http://localhost:4000/images/actors/zendaya.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/actors/zendaya.jpg',
        '2025-04-10',
        1
    ),
    (
        3,
        'Benedict Cumberbatch',
        'Benedict Timothy Carlton Cumberbatch CBE is an English actor known for his work on screen and stage.',
        '2000',
        'http://localhost:4000/images/actors/benedict-cumberbatch.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/actors/benedict-cumberbatch.jpg',
        '2025-04-10',
        0
    ),
    (
        4,
        'Robert Downey Jr.',
        'Robert John Downey Jr. is an American actor and producer.',
        '1970',
        'http://localhost:4000/images/actors/robert-downey-jr.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/actors/robert-downey-jr.jpg',
        '2025-04-10',
        0
    ),
    (
        5,
        'Gwyneth Paltrow',
        'Gwyneth Kate Paltrow is an American actress and businesswoman.',
        '1991',
        'http://localhost:4000/images/actors/gwyneth-paltrow.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/actors/gwyneth-paltrow.jpg',
        '2025-04-10',
        1
    ),
    (
        6,
        'Leonardo DiCaprio',
        'Leonardo Wilhelm DiCaprio is an American actor and film producer.',
        '1991',
        'http://localhost:4000/images/actors/leonardo-dicaprio.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/actors/leonardo-dicaprio.jpg',
        '2025-04-10',
        0
    ),
    (
        7,
        'Joseph Gordon-Levitt',
        'Joseph Leonard Gordon-Levitt is an American actor and filmmaker.',
        '1992',
        'http://localhost:4000/images/actors/joseph-gordon-levitt.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/actors/joseph-gordon-levitt.jpg',
        '2025-04-10',
        0
    ),
    (
        8,
        'Elliot Page',
        'Elliot Page is a Canadian actor and producer.',
        '1997',
        'http://localhost:4000/images/actors/elliot-page.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/actors/elliot-page.jpg',
        '2025-04-10',
        2
    );

SET
    IDENTITY_INSERT Actor OFF;

END
-- Movies - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        Movie
) BEGIN
SET
    IDENTITY_INSERT Movie ON;

INSERT INTO
    Movie (
        Id,
        Title,
        PhotoSrc,
        PhotoSrcProd,
        TrailerSrc,
        Duration,
        RatingImdb,
        DateAired,
        Description
    )
VALUES
    (
        1,
        'Spider-Man: No Way Home',
        'http://localhost:4000/images/movies/1gxZrx9gL9ov2c1NpXimEUzMTmh.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/1gxZrx9gL9ov2c1NpXimEUzMTmh.jpg',
        'https://www.youtube.com/embed/JfVOs4VSpmA',
        148,
        8.7,
        '2021-12-17',
        'Peter Parker is unmasked and no longer able to separate his normal life from the high stakes of being a Super Hero. When he seeks help from Doctor Strange, the stakes become even more dangerous, forcing him to discover what it truly means to be Spider-Man.'
    ),
    (
        2,
        'Iron Man',
        'http://localhost:4000/images/movies/iron-man.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/iron-man.jpg',
        'https://www.youtube.com/embed/8ugaeA-nMTc',
        126,
        7.9,
        '2008-05-02',
        'After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.'
    ),
    (
        3,
        'Inception',
        'http://localhost:4000/images/movies/8c9fce3c0ffa46576423d44b525447edc25f1396.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/8c9fce3c0ffa46576423d44b525447edc25f1396.jpg',
        'https://www.youtube.com/embed/YoHD9XEInc0',
        148,
        8.8,
        '2010-07-16',
        'A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.'
    ),
    (
        4,
        'Blood and Bone',
        'http://localhost:4000/images/movies/5254_1_ladsfgfdgdfgdfgfdgfdgrge.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/5254_1_ladsfgfdgdfgdfgfdgfdgrge.jpg',
        'https://www.youtube.com/embed/KyOtQr5u-uY',
        93,
        6.7,
        '2009-01-17',
        'Ex-con Boun is the new force on the underground street fighting scene in Los Angeles.'
    ),
    (
        5,
        'Freaks Out',
        'http://localhost:4000/images/movies/1TkkTo8UiRl5lWM5qkAISHXg0fU.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/1TkkTo8UiRl5lWM5qkAISHXg0fU.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        141,
        7.4,
        '2021-10-28',
        'Matilde, Cencio, Fulvio, and Mario are united when World War II strikes Rome. Israel, their circus owner, disappears in an attempt to find a place abroad for all of them.'
    ),
    (
        6,
        'My Father''s Violin',
        'http://localhost:4000/images/movies/fathersviolin.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/fathersviolin.jpg',
        'https://www.youtube.com/embed/GAmo87Ep-tI',
        112,
        6.5,
        '2022-11-17',
        'Through their shared grief and connection to music, an orphaned girl bonds with her emotionally distant, successful violinist uncle.'
    ),
    (
        7,
        'The Invisible Guest',
        'http://localhost:4000/images/movies/8c9fce3c0ffa46576423d44b525447edc25f1396.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/8c9fce3c0ffa46576423d44b525447edc25f1396.jpg',
        'https://www.youtube.com/embed/epCg2RbyF80',
        126,
        8.1,
        '2017-03-24',
        'A young businessman faces a lawyer in an attempt to prove his innocence for the murder of his girlfriend.'
    ),
    (
        8,
        'Iron Will',
        'http://localhost:4000/images/movies/6Ujbtp0NklUoQ67s32HyW6R5540.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/6Ujbtp0NklUoQ67s32HyW6R5540.jpg',
        'https://www.youtube.com/embed/giLeHfkJeXU',
        108,
        6.6,
        '1994-01-17',
        'After his father''s death, the responsibility to care for the family falls on Will''s shoulders. He enters a dog race that requires long hours of racing and a steely will to win.'
    ),
    (
        9,
        'Panama',
        'http://localhost:4000/images/movies/82I3tDsGDTMy7lHar84Gz0jUuyW.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/82I3tDsGDTMy7lHar84Gz0jUuyW.jpg',
        'https://www.youtube.com/embed/2GSzkfe1aAY',
        94,
        0,
        '2022-11-18',
        'A former marine is hired by a defense contractor to travel to Panama to complete an arms deal. During the process, he becomes involved in the U.S. invasion of Panama and learns an important lesson about the true nature of political power.'
    ),
    (
        10,
        'Eternals',
        'http://localhost:4000/images/movies/1RjyfPLsZTq3lUdJY7pTzcmpPKl.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/1RjyfPLsZTq3lUdJY7pTzcmpPKl.jpg',
        'https://www.youtube.com/embed/x_me3xsvDgk',
        156,
        6.8,
        '2021-11-05',
        'The Eternals are a team of ancient aliens who have been living on Earth in secret for thousands of years. When an unexpected tragedy forces them out of the shadows, they must reunite against mankind''s oldest enemy.'
    ),
    (
        11,
        'Money Trap',
        'http://localhost:4000/images/movies/4kiVg3QJQghjtRupyfWYI3T1R0O-1.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/4kiVg3QJQghjtRupyfWYI3T1R0O-1.jpg',
        'https://www.youtube.com/embed/gcH0KPQVVH4',
        121,
        6,
        '2022-12-29',
        'Asim Noyan deceives people with his lies and games. Asim Noyan and his gang, whom no one else has been able to capture, get involved in another scam.'
    ),
    (
        12,
        'Inch''Allah',
        'http://localhost:4000/images/movies/9BCd5LdVHQmWqEnDTJ5Ut8idstP-1.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/9BCd5LdVHQmWqEnDTJ5Ut8idstP-1.jpg',
        'https://www.youtube.com/embed/53XLPquQD6Q',
        102,
        6.8,
        '2012-09-09',
        'A Canadian doctor finds her sympathies severely tested while working in the conflict-ravaged Palestinian territories.'
    ),
    (
        13,
        'Mobile Suit Gundam: Hathaway',
        'http://localhost:4000/images/movies/6gw8onh4FKsruBA7Oouv01EFxzn-1.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/6gw8onh4FKsruBA7Oouv01EFxzn-1.jpg',
        'https://www.youtube.com/embed/MzxnPP5TLeU',
        95,
        6.6,
        '2021-06-11',
        'Hathaway Noa becomes part of a terrorist organization called Mufti that organizes an attack on Earth Federation ministers.'
    ),
    (
        14,
        'Rescued by Ruby',
        'http://localhost:4000/images/movies/ruby.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/ruby.jpg',
        'https://www.youtube.com/embed/-Pwxr307O4w',
        90,
        7.3,
        '2022-03-17',
        'Pursuing his dream to join an elite K-9 unit, a state trooper partners with a smart but unruly shelter dog named Ruby.'
    ),
    (
        15,
        'The Girl on the Mountain',
        'http://localhost:4000/images/movies/1ZiZ3eVUWPxJROTkYbH8FBC9UuB.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/1ZiZ3eVUWPxJROTkYbH8FBC9UuB.jpg',
        'https://www.youtube.com/embed/Y0vh8jQ7HMQ',
        94,
        6.4,
        '2021-08-21',
        'When an isolated forester finds a mute little girl wandering alone in the woods, he must protect her from the evil forces determined to end her life.'
    ),
    (
        16,
        'The Weekend Away',
        'http://localhost:4000/images/movies/6MS0QEl7UK2gdFFbHfNwuYlsq4H.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/6MS0QEl7UK2gdFFbHfNwuYlsq4H.jpg',
        'https://www.youtube.com/embed/XpfjN-7Hf-8',
        89,
        5.6,
        '2022-03-03',
        'A weekend getaway to Croatia goes awry when a woman is accused of murdering her best friend. As she attempts to clear her name and uncover the truth, her efforts reveal a painful secret.'
    ),
    (
        17,
        'Black Crab',
        'http://localhost:4000/images/movies/blackcrab.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/blackcrab.jpg',
        'https://www.youtube.com/embed/fmjKsL_-rfw',
        114,
        5.7,
        '2022-03-18',
        'In a post-apocalyptic world, six soldiers on a covert mission must transport a mysterious package across a frozen archipelago.'
    ),
    (
        18,
        'The Extra Man',
        'http://localhost:4000/images/movies/7RhiXoCm6yEflHQvYtoLeAkDhaU.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/7RhiXoCm6yEflHQvYtoLeAkDhaU.jpg',
        'https://www.youtube.com/embed/etxKmplTT9Q',
        108,
        5.8,
        '2010-07-30',
        'A man who escorts wealthy women in Manhattan takes a young man under his wing.'
    ),
    (
        19,
        '14 Peaks: Nothing Is Impossible',
        'http://localhost:4000/images/movies/beyondpossible.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/beyondpossible.jpg',
        'https://www.youtube.com/embed/8QH5hBOoz08',
        101,
        7.8,
        '2021-12-09',
        'Fearless Nepali mountaineer Nirmal Purja embarks on a seemingly impossible quest to summit all 14 of the world''s 8,000-meter peaks in seven months.'
    ),
    (
        20,
        'The Innocents',
        'http://localhost:4000/images/movies/4hIptu4Yre7pIUhFa7GBZlfDTPW.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/4hIptu4Yre7pIUhFa7GBZlfDTPW.jpg',
        'https://www.youtube.com/embed/T8HR-zTRrCM',
        117,
        7.0,
        '2021-06-26',
        'During the long days of the polar summer, a group of children reveal their dark and mysterious powers while the adults aren''t watching. This playtime takes a dangerous turn.'
    ),
    (
        21,
        'Mean Dreams',
        'http://localhost:4000/images/movies/AlowOYyprAAq85PPtE9LvoiYT1b.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/AlowOYyprAAq85PPtE9LvoiYT1b.jpg',
        'https://www.youtube.com/embed/jNOAVTX8PPE',
        108,
        6.1,
        '2016-05-20',
        'A 15-year-old boy steals a bag of drug money and runs off with the girl he loves. As her violent and corrupt police officer father hunts them down, they embark on a journey that will change their lives forever.'
    );

SET
    IDENTITY_INSERT Movie OFF;

END
-- Series - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        Serie
) BEGIN
SET
    IDENTITY_INSERT Serie ON;

INSERT INTO
    Serie (
        Id,
        Title,
        PhotoSrc,
        PhotoSrcProd,
        Description,
        Trailer,
        DateAired,
        RatingImdb
    )
VALUES
    (
        1,
        'Rebelde',
        'http://localhost:4000/images/series/rebelde.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/rebelde.jpg',
        'A group of students at an elite music school face their unique struggles while trying to make it in the music industry.',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2000-01-01',
        5.5
    ),
    (
        2,
        'Snowfall',
        'http://localhost:4000/images/series/snowfall.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/snowfall.jpg',
        'Set in Los Angeles in the 1980s, the series revolves around the first crack epidemic and its impact.',
        'https://www.youtube.com/embed/7GdM7gZ1ip4',
        '2000-01-01',
        5.3
    ),
    (
        3,
        'Man vs Bee',
        'http://localhost:4000/images/series/manbee.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/manbee.jpg',
        'A man finds himself in a war with a bee while house-sitting a luxurious mansion.',
        'https://www.youtube.com/embed/Dm5Y0g4u4DU',
        '2000-01-01',
        5.7
    ),
    (
        4,
        'Moonknight',
        'http://localhost:4000/images/series/moonknight.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/moonknight.jpg',
        'A former U.S. Marine struggles with dissociative identity disorder and is granted the powers of an Egyptian moon god.',
        'https://www.youtube.com/embed/qx6PbFC-8bM',
        '2000-01-01',
        5.2
    ),
    (
        5,
        'Peacemaker',
        'http://localhost:4000/images/series/peacemaker.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/peacemaker.jpg',
        'The continuing story of Peacemaker – a compellingly vainglorious man who believes in peace at any cost.',
        'https://www.youtube.com/embed/8-VpHwnh4d4',
        '2000-01-01',
        5.8
    ),
    (
        6,
        'Top Boy',
        'http://localhost:4000/images/series/topboy.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/topboy.jpg',
        'Two London drug dealers ply their lucrative trade at a public housing estate in East London.',
        'https://www.youtube.com/embed/2gRFDx6Cz7k',
        '2000-01-01',
        5.0
    ),
    (
        7,
        'Ganglands',
        'http://localhost:4000/images/series/ganglands.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/ganglands.jpg',
        'A professional thief with a high-stakes heist in mind teams up with a gang.',
        'https://www.youtube.com/embed/v1GcRDY-S5Y',
        '2000-01-01',
        5.6
    );

SET
    IDENTITY_INSERT Serie OFF;

END
-- Seasons - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        Season
) BEGIN
SET
    IDENTITY_INSERT Season ON;

INSERT INTO
    Season (
        Id,
        Title,
        PhotoSrc,
        PhotoSrcProd,
        Description,
        TrailerSrc,
        DateAired,
        RatingImdb,
        SerieId
    )
VALUES
    (
        1,
        'Rebelde S01',
        'http://localhost:4000/images/series/rebelde.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/rebelde.jpg',
        'Description for Season 1 in Rebelde.',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2000-01-01',
        5.5,
        1
    ),
    (
        2,
        'Snowfall S01',
        'http://localhost:4000/images/series/snowfall.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/snowfall.jpg',
        'Description for Season 1 in Snowfall.',
        'https://www.youtube.com/embed/7GdM7gZ1ip4',
        '2000-01-01',
        5.3,
        2
    ),
    (
        3,
        'Man vs Bee S01',
        'http://localhost:4000/images/series/manbee.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/manbee.jpg',
        'Description for Season 1 in Man vs Bee.',
        'https://www.youtube.com/embed/Dm5Y0g4u4DU',
        '2000-01-01',
        5.7,
        3
    ),
    (
        4,
        'Man vs Bee S02',
        'http://localhost:4000/images/series/manbee.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/manbee.jpg',
        'Description for Season 2 in Man vs Bee.',
        'https://www.youtube.com/embed/PA8OQX4qW0M',
        '2000-01-01',
        5.0,
        3
    ),
    (
        5,
        'Moonknight S01',
        'http://localhost:4000/images/series/moonknight.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/moonknight.jpg',
        'Description for Season 1 in Moonknight.',
        'https://www.youtube.com/embed/qx6PbFC-8bM',
        '2000-01-01',
        5.2,
        4
    ),
    (
        6,
        'Moonknight S02',
        'http://localhost:4000/images/series/moonknight.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/moonknight.jpg',
        'Description for Season 2 in Moonknight.',
        'https://www.youtube.com/embed/N4k9EFdxFCk',
        '2000-01-01',
        5.5,
        4
    ),
    (
        7,
        'Peacemaker S01',
        'http://localhost:4000/images/series/peacemaker.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/peacemaker.jpg',
        'Description for Season 1 in Peacemaker.',
        'https://www.youtube.com/embed/8-VpHwnh4d4',
        '2000-01-01',
        5.8,
        5
    ),
    (
        8,
        'Peacemaker S02',
        'http://localhost:4000/images/series/peacemaker.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/peacemaker.jpg',
        'Description for Season 2 in Peacemaker.',
        'https://www.youtube.com/embed/LeZTlvK7BR4',
        '2000-01-01',
        5.5,
        5
    ),
    (
        9,
        'Top Boy S01',
        'http://localhost:4000/images/series/topboy.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/topboy.jpg',
        'Description for Season 1 in Top Boy.',
        'https://www.youtube.com/embed/2gRFDx6Cz7k',
        '2000-01-01',
        5.0,
        6
    ),
    (
        10,
        'Ganglands S01',
        'http://localhost:4000/images/series/ganglands.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/ganglands.jpg',
        'Description for Season 1 in Ganglands.',
        'https://www.youtube.com/embed/v1GcRDY-S5Y',
        '2000-01-01',
        5.6,
        7
    ),
    (
        11,
        'Ganglands S02',
        'http://localhost:4000/images/series/ganglands.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/ganglands.jpg',
        'Description for Season 2 in Ganglands.',
        'https://www.youtube.com/embed/WF9mGrcKnU8',
        '2000-01-01',
        6.1,
        7
    );

SET
    IDENTITY_INSERT Season OFF;

END
-- -- Users - Only insert if table is empty
-- IF NOT EXISTS (SELECT 1 FROM User)
-- BEGIN
--     SET IDENTITY_INSERT User ON;
--     INSERT INTO User (Id, UserName, Email, Password, Role, Bio, Gender, Phone, CountryFrom, Active, Subscribed, CanResetPassword) VALUES
--     (1, 'admin', 'admin@movielandia.com', '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO', 0, 'System Administrator', 0, '+11234567890', 'United States', 1, 0, 0),
--     (2, 'moviebuff', 'moviebuff@example.com', '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO', 1, 'Passionate about movies', 0, '+11234567891', 'Canada', 1, 0, 0),
--     (3, 'cinephile', 'cinephile@example.com', '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO', 1, 'Love analyzing films', 1, '+11234567892', 'United Kingdom', 1, 0, 0);
--     SET IDENTITY_INSERT User OFF;
-- END
-- Movie Genres - Only insert if table is empty
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
    (1, 1, 1), -- Spider-Man: Action
    (2, 1, 4), -- Spider-Man: Science Fiction
    (3, 1, 10), -- Spider-Man: Fantasy
    (4, 2, 1), -- Iron Man: Action
    (5, 2, 4), -- Iron Man: Science Fiction
    (6, 2, 11), -- Iron Man: Adventure
    (7, 3, 1), -- Inception: Action
    (8, 3, 4), -- Inception: Science Fiction
    (9, 3, 12), -- Inception: Mystery
    (10, 4, 1), -- Blood and Bone: Action
    (11, 4, 2), -- Blood and Bone: Drama
    (12, 4, 18), -- Blood and Bone: Sport
    (13, 5, 1), -- Freaks Out: Action
    (14, 5, 2), -- Freaks Out: Drama
    (15, 5, 15), -- Freaks Out: War
    (16, 6, 2), -- My Father's Violin: Drama
    (17, 6, 6);

-- My Father's Violin: Romance
SET
    IDENTITY_INSERT MovieGenre OFF;

END
-- Serie Genres - Only insert if table is empty
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
    (1, 1, 2), -- Rebelde: Drama
    (2, 1, 3), -- Rebelde: Comedy
    (3, 1, 22), -- Rebelde: Music
    (4, 2, 2), -- Snowfall: Drama
    (5, 2, 13), -- Snowfall: Crime
    (6, 3, 3), -- Man vs Bee: Comedy
    (7, 3, 14), -- Man vs Bee: Family
    (8, 4, 1), -- Moonknight: Action
    (9, 4, 4), -- Moonknight: Science Fiction
    (10, 4, 10);

-- Moonknight: Fantasy
SET
    IDENTITY_INSERT SerieGenre OFF;

END
-- Cast in Movies - Only insert if table is empty
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
    (1, 1, 1), -- Tom Holland in Spider-Man: No Way Home
    (2, 1, 2), -- Zendaya in Spider-Man: No Way Home
    (3, 1, 3), -- Benedict Cumberbatch in Spider-Man: No Way Home
    (4, 2, 4), -- Robert Downey Jr. in Iron Man
    (5, 2, 5), -- Gwyneth Paltrow in Iron Man
    (6, 3, 6), -- Leonardo DiCaprio in Inception
    (7, 3, 7), -- Joseph Gordon-Levitt in Inception
    (8, 3, 8);

-- Elliot Page in Inception
SET
    IDENTITY_INSERT CastMovie OFF;

END
-- Cast in Series - Only insert if table is empty
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
    (1, 1, 1), -- Tom Holland in Rebelde
    (2, 1, 2), -- Zendaya in Rebelde
    (3, 2, 3), -- Benedict Cumberbatch in Snowfall
    (4, 2, 4), -- Robert Downey Jr. in Snowfall
    (5, 3, 5), -- Gwyneth Paltrow in Man vs Bee
    (6, 3, 6), -- Leonardo DiCaprio in Man vs Bee
    (7, 4, 7), -- Joseph Gordon-Levitt in Moonknight
    (8, 4, 8);

-- Elliot Page in Moonknight
SET
    IDENTITY_INSERT CastSerie OFF;

END
-- Crew - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        Crew
) BEGIN
SET
    IDENTITY_INSERT Crew ON;

INSERT INTO
    Crew (
        Id,
        Fullname,
        Description,
        Debut,
        PhotoSrc,
        PhotoSrcProd,
        CreatedAt
    )
VALUES
    (
        1,
        'Jon Watts',
        'American filmmaker and director of Spider-Man: No Way Home',
        '2014',
        'http://localhost:4000/images/crew/jon-watts.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/crew/jon-watts.jpg',
        '2025-04-10'
    ),
    (
        2,
        'Jon Favreau',
        'American actor, director, producer, and screenwriter',
        '1992',
        'http://localhost:4000/images/crew/jon-favreau.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/crew/jon-favreau.jpg',
        '2025-04-10'
    ),
    (
        3,
        'Christopher Nolan',
        'British-American filmmaker known for his sci-fi and psychological films',
        '1998',
        'http://localhost:4000/images/crew/christopher-nolan.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/crew/christopher-nolan.jpg',
        '2025-04-10'
    ),
    (
        4,
        'Kevin Feige',
        'American film producer and president of Marvel Studios',
        '2000',
        'http://localhost:4000/images/crew/kevin-feige.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/crew/kevin-feige.jpg',
        '2025-04-10'
    ),
    (
        5,
        'Roger Deakins',
        'Celebrated cinematographer recognized for his work on ''Blade Runner 2049'' and ''1917''.',
        '1984',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        6,
        'Emmanuel Lubezki',
        'Award-winning cinematographer known for his work on ''Gravity'' and ''Birdman''.',
        '1991',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        7,
        'Hans Zimmer',
        'A celebrated composer known for scores in ''The Lion King'' and ''Inception''.',
        '1984',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        8,
        'John Williams',
        'A legendary composer known for ''Star Wars'', ''Jurassic Park'', and ''Harry Potter''.',
        '1958',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        9,
        'Quentin Tarantino',
        'Writer and director known for ''Pulp Fiction'' and ''Kill Bill''.',
        '1992',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        10,
        'Aaron Sorkin',
        'Known for his distinctive dialogue in ''The West Wing'' and ''The Social Network''.',
        '1988',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        11,
        'Denis Villeneuve',
        'Critically acclaimed director known for ''Arrival'' and ''Dune''.',
        '1998',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        12,
        'Greta Gerwig',
        'Director and writer known for ''Lady Bird'' and ''Little Women''.',
        '2006',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        13,
        'Rachel Morrison',
        'Known for her work on ''Mudbound'' and ''Black Panther''.',
        '2004',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        14,
        'Howard Shore',
        'Composer for ''The Lord of the Rings'' and ''The Departed''.',
        '1979',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        15,
        'Lynn Shelton',
        'Director of indie films like ''Humpday'' and ''Your Sister''s Sister''.',
        '2006',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        16,
        'Wally Pfister',
        'Known for his cinematography on ''Inception'' and ''The Dark Knight''.',
        '1990',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        17,
        'Nora Ephron',
        'Screenwriter and director of romantic comedies like ''When Harry Met Sally''.',
        '1983',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        18,
        'Spike Lee',
        'Known for films that address race relations like ''Do the Right Thing''.',
        '1986',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        19,
        'Robert Richardson',
        'Worked on ''Inglourious Basterds'' and ''Shutter Island''.',
        '1985',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        20,
        'Trent Reznor',
        'Composer for films such as ''The Social Network'' and ''Gone Girl''.',
        '2008',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        21,
        'Sofia Coppola',
        'Director known for ''Lost in Translation'' and ''The Virgin Suicides''.',
        '1999',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        22,
        'Michael Giacchino',
        'Known for his work on Pixar films and ''Jurassic World''.',
        '1997',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    );

SET
    IDENTITY_INSERT Crew OFF;

END
-- Crew in Movies - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        CrewMovie
) BEGIN
SET
    IDENTITY_INSERT CrewMovie ON;

INSERT INTO
    CrewMovie (Id, MovieId, CrewId)
VALUES
    (1, 1, 1), -- Jon Watts in Spider-Man: No Way Home
    (2, 1, 4), -- Kevin Feige in Spider-Man: No Way Home
    (3, 2, 2), -- Jon Favreau in Iron Man
    (4, 2, 4), -- Kevin Feige in Iron Man
    (5, 3, 3);

-- Christopher Nolan in Inception
SET
    IDENTITY_INSERT CrewMovie OFF;

END
-- Crew in Series - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        CrewSerie
) BEGIN
SET
    IDENTITY_INSERT CrewSerie ON;

INSERT INTO
    CrewSerie (Id, SerieId, CrewId)
VALUES
    (1, 4, 4);

-- Kevin Feige in Moonknight
SET
    IDENTITY_INSERT CrewSerie OFF;

END
-- Forum Categories - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        ForumCategory
) BEGIN
SET
    IDENTITY_INSERT ForumCategory ON;

INSERT INTO
    ForumCategory (Id, Name, Description)
VALUES
    (
        1,
        'Movies Discussion',
        'Discuss your favorite movies and new releases'
    ),
    (
        2,
        'TV Series Discussion',
        'Discuss your favorite TV series and new episodes'
    ),
    (
        3,
        'Technical Support',
        'Get help with technical issues on the platform'
    ),
    (
        4,
        'Actors & Crew',
        'Discuss your favorite actors, directors, and film crew'
    ),
    (
        5,
        'Reviews & Recommendations',
        'Share your reviews and get recommendations'
    );

SET
    IDENTITY_INSERT ForumCategory OFF;

END
-- Forum Tags - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        ForumTag
) BEGIN
SET
    IDENTITY_INSERT ForumTag ON;

INSERT INTO
    ForumTag (Id, Name, Description, Color)
VALUES
    (
        1,
        'Announcement',
        'Official announcements from the MovieLandia team',
        '#FF5722'
    ),
    (
        2,
        'Question',
        'Questions about movies, series, or the platform',
        '#2196F3'
    ),
    (
        3,
        'Discussion',
        'General discussions about movies and TV shows',
        '#4CAF50'
    ),
    (
        4,
        'Review',
        'Movie and TV show reviews',
        '#9C27B0'
    ),
    (
        5,
        'News',
        'Latest news about movies and TV shows',
        '#F44336'
    ),
    (
        6,
        'Recommendation',
        'Recommendations for movies and TV shows',
        '#00BCD4'
    ),
    (
        7,
        'Spoiler',
        'Contains spoilers - read with caution',
        '#FF9800'
    ),
    (
        8,
        'Theory',
        'Theories about movies and TV shows',
        '#673AB7'
    );

SET
    IDENTITY_INSERT ForumTag OFF;

END
-- Movie Reviews - Only if not already present
IF NOT EXISTS (
    SELECT
        1
    FROM
        MovieReview
    WHERE
        Id > 3
) BEGIN
-- Existing movie reviews 1-3 are already inserted, continue from 4
SET
    IDENTITY_INSERT MovieReview ON;

INSERT INTO
    MovieReview (Id, Content, Rating, CreatedAt, UserId, MovieId)
VALUES
    (
        4,
        'Visually stunning with impressive special effects.',
        4.2,
        '2025-04-23',
        1,
        5
    ),
    (
        5,
        'A touching story about family and music.',
        4.0,
        '2025-04-23',
        2,
        6
    ),
    (
        6,
        'Intense action sequences but plot is predictable.',
        3.5,
        '2025-04-23',
        3,
        4
    ),
    (
        7,
        'A masterpiece of visual and narrative storytelling.',
        5.0,
        '2025-04-23',
        1,
        3
    );

SET
    IDENTITY_INSERT MovieReview OFF;

END
-- Movie Ratings - Only if not already present
IF NOT EXISTS (
    SELECT
        1
    FROM
        UserMovieRating
    WHERE
        Id > 3
) BEGIN
-- Existing ratings 1-3 are already inserted, continue from 4
SET
    IDENTITY_INSERT UserMovieRating ON;

INSERT INTO
    UserMovieRating (Id, Rating, UserId, MovieId)
VALUES
    (4, 4.2, 1, 5),
    (5, 4.0, 2, 6),
    (6, 3.5, 3, 4),
    (7, 5.0, 1, 3);

SET
    IDENTITY_INSERT UserMovieRating OFF;

END
-- Movie Favorites - Only if not already present
IF NOT EXISTS (
    SELECT
        1
    FROM
        UserMovieFavorite
    WHERE
        Id > 3
) BEGIN
-- Existing favorites 1-3 are already inserted, continue from 4
SET
    IDENTITY_INSERT UserMovieFavorite ON;

INSERT INTO
    UserMovieFavorite (Id, UserId, MovieId)
VALUES
    (4, 1, 3),
    (5, 2, 5),
    (6, 3, 6);

SET
    IDENTITY_INSERT UserMovieFavorite OFF;

END
-- Genre Favorites - Only if not already present
IF NOT EXISTS (
    SELECT
        1
    FROM
        UserGenreFavorite
    WHERE
        Id > 4
) BEGIN
-- Existing genre favorites 1-4 are already inserted, continue from 5
SET
    IDENTITY_INSERT UserGenreFavorite ON;

INSERT INTO
    UserGenreFavorite (Id, UserId, GenreId)
VALUES
    (5, 2, 3), -- MovieBuff likes Comedy
    (6, 3, 7), -- Cinephile likes Thriller
    (7, 1, 10), -- Admin likes Fantasy
    (8, 2, 4);

-- MovieBuff likes Sci-Fi
SET
    IDENTITY_INSERT UserGenreFavorite OFF;

END
-- Upvote Movie Reviews - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        UpvoteMovieReview
) BEGIN
SET
    IDENTITY_INSERT UpvoteMovieReview ON;

INSERT INTO
    UpvoteMovieReview (Id, UserId, MovieId, MovieReviewId)
VALUES
    (1, 1, 1, 2), -- Admin upvoted MovieBuff's review of Spider-Man
    (2, 2, 2, 1), -- MovieBuff upvoted Admin's review of Iron Man
    (3, 3, 3, 1), -- Cinephile upvoted Admin's review of Inception
    (4, 1, 2, 3), -- Admin upvoted Cinephile's review of Iron Man
    (5, 2, 3, 3);

-- MovieBuff upvoted Cinephile's review of Inception
SET
    IDENTITY_INSERT UpvoteMovieReview OFF;

END
-- Downvote Movie Reviews - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        DownvoteMovieReview
) BEGIN
SET
    IDENTITY_INSERT DownvoteMovieReview ON;

INSERT INTO
    DownvoteMovieReview (Id, UserId, MovieId, MovieReviewId)
VALUES
    (1, 3, 1, 2);

-- Cinephile downvoted MovieBuff's review of Spider-Man
SET
    IDENTITY_INSERT DownvoteMovieReview OFF;

END
-- Serie Reviews - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        SerieReview
) BEGIN
SET
    IDENTITY_INSERT SerieReview ON;

INSERT INTO
    SerieReview (Id, Content, Rating, CreatedAt, UserId, SerieId)
VALUES
    (
        1,
        'Great character development and engaging storyline.',
        4.5,
        '2025-04-23',
        1,
        1
    ),
    (
        2,
        'Compelling drama with excellent performances.',
        4.0,
        '2025-04-23',
        2,
        2
    ),
    (
        3,
        'Hilarious comedy with a unique premise.',
        4.8,
        '2025-04-23',
        3,
        3
    ),
    (
        4,
        'Intriguing concept but execution could be better.',
        3.5,
        '2025-04-23',
        1,
        4
    );

SET
    IDENTITY_INSERT SerieReview OFF;

END
-- Season Reviews - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        SeasonReview
) BEGIN
SET
    IDENTITY_INSERT SeasonReview ON;

INSERT INTO
    SeasonReview (Id, Content, Rating, CreatedAt, UserId, SeasonId)
VALUES
    (
        1,
        'Strong start to the series with great character introductions.',
        4.5,
        '2025-04-23',
        1,
        1
    ),
    (
        2,
        'Interesting premise with solid performances.',
        4.0,
        '2025-04-23',
        2,
        2
    ),
    (
        3,
        'Hilarious throughout with great pacing.',
        4.8,
        '2025-04-23',
        3,
        3
    ),
    (
        4,
        'Great improvement on the first season.',
        4.2,
        '2025-04-23',
        1,
        4
    );

SET
    IDENTITY_INSERT SeasonReview OFF;

END
-- User Activities - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        UserActivity
) BEGIN
SET
    IDENTITY_INSERT UserActivity ON;

INSERT INTO
    UserActivity (
        Id,
        Action,
        EntityType,
        EntityId,
        CreatedAt,
        UserId,
        IsRead
    )
VALUES
    (
        1,
        'Watched Movie',
        'Movie',
        1,
        '2025-04-20',
        1,
        1
    ),
    (2, 'Rated Movie', 'Movie', 1, '2025-04-20', 1, 1),
    (
        3,
        'Added to Favorites',
        'Movie',
        1,
        '2025-04-20',
        1,
        1
    ),
    (4, 'Wrote Review', 'Movie', 1, '2025-04-20', 1, 1),
    (
        5,
        'Watched Episode',
        'Episode',
        1,
        '2025-04-21',
        2,
        1
    ),
    (6, 'Rated Series', 'Serie', 1, '2025-04-21', 2, 1),
    (
        7,
        'Added to Favorites',
        'Serie',
        1,
        '2025-04-21',
        2,
        1
    ),
    (8, 'Wrote Review', 'Serie', 1, '2025-04-21', 2, 1);

SET
    IDENTITY_INSERT UserActivity OFF;

END
-- Episodes - Only insert if table is empty
IF NOT EXISTS (
    SELECT
        1
    FROM
        Episode
) BEGIN
SET
    IDENTITY_INSERT Episode ON;

INSERT INTO
    Episode (
        Id,
        Title,
        Description,
        Duration,
        PhotoSrc,
        PhotoSrcProd,
        TrailerSrc,
        DateAired,
        SeasonId
    )
VALUES
    (
        1,
        'Rebelde S01E01',
        'First episode of Rebelde Season 1',
        45,
        'http://localhost:4000/images/series/rebelde.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/rebelde.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2000-01-01',
        1
    ),
    (
        2,
        'Rebelde S01E02',
        'Second episode of Rebelde Season 1',
        42,
        'http://localhost:4000/images/series/rebelde.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/rebelde.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2000-01-08',
        1
    ),
    (
        3,
        'Snowfall S01E01',
        'First episode of Snowfall Season 1',
        52,
        'http://localhost:4000/images/series/snowfall.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/snowfall.jpg',
        'https://www.youtube.com/embed/7GdM7gZ1ip4',
        '2000-01-01',
        2
    ),
    (
        4,
        'Man vs Bee S01E01',
        'First episode of Man vs Bee Season 1',
        30,
        'http://localhost:4000/images/series/manbee.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/manbee.jpg',
        'https://www.youtube.com/embed/Dm5Y0g4u4DU',
        '2000-01-01',
        3
    ),
    (
        5,
        'Man vs Bee S01E02',
        'Second episode of Man vs Bee Season 1',
        42,
        'http://localhost:4000/images/series/manbee.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/manbee.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2022-06-18',
        3
    ),
    (
        6,
        'Man vs Bee S02E01',
        'First episode of Man vs Bee Season 2',
        31,
        'http://localhost:4000/images/series/manbee.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/manbee.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2023-01-01',
        4
    ),
    (
        7,
        'Man vs Bee S02E02',
        'Second episode of Man vs Bee Season 2',
        15,
        'http://localhost:4000/images/series/manbee.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/manbee.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2023-01-08',
        4
    ),
    (
        8,
        'Moonknight S01E01',
        'First episode of Moonknight Season 1',
        39,
        'http://localhost:4000/images/series/moonknight.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/moonknight.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2022-03-30',
        5
    ),
    (
        9,
        'Moonknight S01E02',
        'Second episode of Moonknight Season 1',
        23,
        'http://localhost:4000/images/series/moonknight.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/moonknight.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2022-04-06',
        5
    ),
    (
        10,
        'Moonknight S02E01',
        'First episode of Moonknight Season 2',
        38,
        'http://localhost:4000/images/series/moonknight.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/moonknight.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2024-01-01',
        6
    ),
    (
        11,
        'Moonknight S02E02',
        'Second episode of Moonknight Season 2',
        40,
        'http://localhost:4000/images/series/moonknight.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/moonknight.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2024-01-08',
        6
    ),
    (
        12,
        'Peacemaker S01E01',
        'First episode of Peacemaker Season 1',
        15,
        'http://localhost:4000/images/series/peacemaker.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/peacemaker.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2022-01-13',
        7
    ),
    (
        13,
        'Peacemaker S01E02',
        'Second episode of Peacemaker Season 1',
        15,
        'http://localhost:4000/images/series/peacemaker.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/peacemaker.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2022-01-20',
        7
    ),
    (
        14,
        'Peacemaker S02E01',
        'First episode of Peacemaker Season 2',
        39,
        'http://localhost:4000/images/series/peacemaker.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/peacemaker.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2024-01-01',
        8
    ),
    (
        15,
        'Top Boy S01E01',
        'First episode of Top Boy Season 1',
        15,
        'http://localhost:4000/images/series/topboy.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/topboy.jpg',
        'https://www.youtube.com/embed/D8La5G1DzCM',
        '2023-02-20',
        9
    );

SET
    IDENTITY_INSERT Episode OFF;

END