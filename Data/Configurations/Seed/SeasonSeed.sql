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
    ),
    (
        12,
        'Ozark S01',
        'http://localhost:4000/images/series/ozark.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/ozark.jpg',
        'Description for Season 1 in Ozark.',
        'https://www.youtube.com/embed/Jmco5ErG2Zk',
        '2000-01-01',
        6.1,
        8
    ),
    (
        13,
        'Resident Alien S01',
        'http://localhost:4000/images/series/alien.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/alien.jpg',
        'Description for Season 1 in Resident Alien.',
        'https://www.youtube.com/embed/mC7GJyt3gD4',
        '2000-01-01',
        5.5,
        9
    ),
    (
        14,
        'Bridgerton S01',
        'http://localhost:4000/images/series/bridgerton.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/bridgerton.jpg',
        'Description for Season 1 in Bridgerton.',
        'https://www.youtube.com/embed/2uBCt7AvHsQ',
        '2000-01-01',
        5.9,
        10
    ),
    (
        15,
        'Bridgerton S02',
        'http://localhost:4000/images/series/bridgerton.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/bridgerton.jpg',
        'Description for Season 2 in Bridgerton.',
        'https://www.youtube.com/embed/BDHBDtKFrGQ',
        '2000-01-01',
        5.6,
        10
    ),
    (
        16,
        'Superman and Lois S01',
        'http://localhost:4000/images/series/superman.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/superman.jpg',
        'Description for Season 1 in Superman & Lois.',
        'https://www.youtube.com/embed/mXjpZy0j8_M',
        '2000-01-01',
        5.9,
        11
    ),
    (
        17,
        'Superman and Lois S02',
        'http://localhost:4000/images/series/superman.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/superman.jpg',
        'Description for Season 2 in Superman & Lois.',
        'https://www.youtube.com/embed/Kte1K7nGFts',
        '2000-01-01',
        5.3,
        11
    ),
    (
        18,
        'Attack on Titan S01',
        'http://localhost:4000/images/series/aot.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/aot.png',
        'Description for Season 1 in Attack on Titan.',
        'https://www.youtube.com/embed/0lEWTieGV3U',
        '2000-01-01',
        6.3,
        12
    ),
    (
        19,
        'Kengan Ashura S01',
        'http://localhost:4000/images/series/baki.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/baki.png',
        'Description for Season 1 in Kengan Ashura.',
        'https://www.youtube.com/embed/4QMY0fxaDQ0',
        '2000-01-01',
        5.5,
        13
    ),
    (
        20,
        'Elite S01',
        'http://localhost:4000/images/series/elite.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/elite.png',
        'Description for Season 1 in Elite.',
        'https://www.youtube.com/embed/xrcd1tVbK7Y',
        '2000-01-01',
        5.8,
        14
    ),
    (
        21,
        'Elite S02',
        'http://localhost:4000/images/series/elite.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/elite.png',
        'Description for Season 2 in Elite.',
        'https://www.youtube.com/embed/8-CKQ_X5Fz4',
        '2000-01-01',
        5.4,
        14
    ),
    (
        22,
        'The Flash S01',
        'http://localhost:4000/images/series/flash.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/flash.png',
        'Description for Season 1 in The Flash.',
        'https://www.youtube.com/embed/RLckrnS9O4E',
        '2000-01-01',
        5.2,
        15
    ),
    (
        23,
        'Power Book IV Force S01',
        'http://localhost:4000/images/series/force.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/force.png',
        'Description for Season 1 in Power Book IV Force.',
        'https://www.youtube.com/embed/Ey6afOM2TbI',
        '2000-01-01',
        5.0,
        16
    ),
    (
        24,
        'Power Book IV Force S02',
        'http://localhost:4000/images/series/force.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/force.png',
        'Description for Season 2 in Power Book IV Force.',
        'https://www.youtube.com/embed/LugI0VymBsQ',
        '2000-01-01',
        6.4,
        16
    ),
    (
        25,
        'Halo S01',
        'http://localhost:4000/images/series/halo.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/halo.png',
        'Description for Season 1 in Halo.',
        'https://www.youtube.com/embed/7FfdSuZq0hw',
        '2000-01-01',
        5.8,
        17
    ),
    (
        26,
        'The Last Kingdom S01',
        'http://localhost:4000/images/series/kingdom.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/kingdom.png',
        'Description for Season 1 in The Last Kingdom.',
        'https://www.youtube.com/embed/4ayIztm4BL4',
        '2000-01-01',
        6.1,
        18
    ),
    (
        27,
        'Knightfall S01',
        'http://localhost:4000/images/series/knightfall.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/knightfall.png',
        'Description for Season 1 in Knightfall.',
        'https://www.youtube.com/embed/CrF8A6uZ2fA',
        '2000-01-01',
        6.4,
        19
    ),
    (
        28,
        'Knightfall S02',
        'http://localhost:4000/images/series/knightfall.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/knightfall.png',
        'Description for Season 2 in Knightfall.',
        'https://www.youtube.com/embed/Ma8XxR5Fj54',
        '2000-01-01',
        5.5,
        19
    );

SET
    IDENTITY_INSERT Season OFF;

END