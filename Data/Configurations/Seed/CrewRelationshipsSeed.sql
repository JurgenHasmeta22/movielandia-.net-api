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

END IF NOT EXISTS (
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
    -- Movie 1 crew
    (1, 1, 1),
    (2, 1, 3),
    (3, 1, 5),
    (4, 1, 11),
    (5, 1, 6),
    (6, 1, 7),
    (7, 1, 8),
    -- Movie 2 crew
    (8, 2, 2),
    (9, 2, 4),
    (10, 2, 6),
    (11, 2, 12),
    (12, 2, 9),
    (13, 2, 13),
    (14, 2, 1),
    -- Movie 3 crew
    (15, 3, 7),
    (16, 3, 8),
    (17, 3, 9),
    (18, 3, 13),
    (19, 3, 10),
    (20, 3, 4),
    (21, 3, 2),
    -- Movie 4 crew
    (22, 4, 10),
    (23, 4, 1),
    (24, 4, 3),
    (25, 4, 14),
    (26, 4, 9),
    (27, 4, 8),
    (28, 4, 7),
    -- Movie 5 crew
    (29, 5, 2),
    (30, 5, 4),
    (31, 5, 6),
    (32, 5, 15),
    (33, 5, 1),
    (34, 5, 3),
    (35, 5, 9);

SET
    IDENTITY_INSERT CrewMovie OFF;

END IF NOT EXISTS (
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
    -- Series 1 crew
    (1, 1, 1),
    (2, 1, 3),
    (3, 1, 5),
    (4, 1, 11),
    (5, 1, 6),
    (6, 1, 7),
    (7, 1, 8),
    -- Series 2 crew
    (8, 2, 2),
    (9, 2, 4),
    (10, 2, 6),
    (11, 2, 12),
    (12, 2, 9),
    (13, 2, 13),
    (14, 2, 1),
    -- Series 3 crew
    (15, 3, 7),
    (16, 3, 8),
    (17, 3, 9),
    (18, 3, 13),
    (19, 3, 10),
    (20, 3, 4),
    (21, 3, 2),
    -- Series 4 crew
    (22, 4, 10),
    (23, 4, 1),
    (24, 4, 3),
    (25, 4, 14),
    (26, 4, 9),
    (27, 4, 8),
    (28, 4, 7),
    -- Series 5 crew
    (29, 5, 2),
    (30, 5, 4),
    (31, 5, 6),
    (32, 5, 15),
    (33, 5, 1),
    (34, 5, 3),
    (35, 5, 9);

SET
    IDENTITY_INSERT CrewSerie OFF;

END