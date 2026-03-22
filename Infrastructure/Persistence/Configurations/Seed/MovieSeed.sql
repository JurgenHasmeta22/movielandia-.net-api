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
        2,
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
        3,
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
        4,
        'Blood and Bone',
        'http://localhost:4000/images/movies/5254_1_ladsfgfdgdfgdfgfdgfdgrge.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/5254_1_ladsfgfdgdfgdfgfdgfdgrge.jpg',
        'https://www.youtube.com/embed/KyOtQr5u-uY',
        93,
        6.7,
        '2009-01-17',
        'Ex-con Boun is the new force on the underground street fighting scene in Los Angeles. When he defeats the reigning champion, the local gangster boss wants to enlist Boun in a series of high-stakes international matches. Boun''s refusal sets off an explosive showdown between two powerful enemies risking everything.'
    ),
    (
        5,
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
        6,
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
        7,
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
        8,
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
        9,
        'Money Trap',
        'http://localhost:4000/images/movies/4kiVg3QJQghjtRupyfWYI3T1R0O-1.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/movies/4kiVg3QJQghjtRupyfWYI3T1R0O-1.jpg',
        'https://www.youtube.com/embed/gcH0KPQVVH4',
        121,
        6.0,
        '2022-12-29',
        'Asim Noyan deceives people with his lies and games. Asim Noyan and his gang, whom no one else has been able to capture, get involved in another scam.'
    ),
    (
        10,
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
        11,
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
        12,
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
        13,
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
        14,
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
        15,
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
        16,
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
        17,
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
        18,
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
        19,
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