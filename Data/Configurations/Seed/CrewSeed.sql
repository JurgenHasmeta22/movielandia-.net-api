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
        CreatedAt,
        Role
    )
VALUES
    (
        1,
        'Steven Spielberg',
        'A renowned filmmaker known for iconic films such as ''Jurassic Park'' and ''E.T.''.',
        '1971',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Director'
    ),
    (
        2,
        'Christopher Nolan',
        'Director known for his work on ''Inception'' and ''The Dark Knight'' trilogy.',
        '1998',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Director'
    ),
    (
        3,
        'Roger Deakins',
        'Celebrated cinematographer recognized for his work on ''Blade Runner 2049'' and ''1917''.',
        '1984',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Cinematographer'
    ),
    (
        4,
        'Emmanuel Lubezki',
        'Award-winning cinematographer known for his work on ''Gravity'' and ''Birdman''.',
        '1991',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Cinematographer'
    ),
    (
        5,
        'Hans Zimmer',
        'A celebrated composer known for scores in ''The Lion King'' and ''Inception''.',
        '1984',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Composer'
    ),
    (
        6,
        'John Williams',
        'A legendary composer known for ''Star Wars'', ''Jurassic Park'', and ''Harry Potter''.',
        '1958',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Composer'
    ),
    (
        7,
        'Quentin Tarantino',
        'Writer and director known for ''Pulp Fiction'' and ''Kill Bill''.',
        '1992',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Writer'
    ),
    (
        8,
        'Aaron Sorkin',
        'Known for his distinctive dialogue in ''The West Wing'' and ''The Social Network''.',
        '1988',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Writer'
    ),
    (
        9,
        'Denis Villeneuve',
        'Critically acclaimed director known for ''Arrival'' and ''Dune''.',
        '1998',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Director'
    ),
    (
        10,
        'Greta Gerwig',
        'Director and writer known for ''Lady Bird'' and ''Little Women''.',
        '2006',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Director'
    ),
    (
        11,
        'Rachel Morrison',
        'Known for her work on ''Mudbound'' and ''Black Panther''.',
        '2004',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Cinematographer'
    ),
    (
        12,
        'Howard Shore',
        'Composer for ''The Lord of the Rings'' and ''The Departed''.',
        '1979',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Composer'
    ),
    (
        13,
        'Lynn Shelton',
        'Director of indie films like ''Humpday'' and ''Your Sister''s Sister''.',
        '2006',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Director'
    ),
    (
        14,
        'Wally Pfister',
        'Known for his cinematography on ''Inception'' and ''The Dark Knight''.',
        '1990',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Cinematographer'
    ),
    (
        15,
        'Nora Ephron',
        'Screenwriter and director of romantic comedies like ''When Harry Met Sally''.',
        '1983',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Writer'
    ),
    (
        16,
        'Spike Lee',
        'Known for films that address race relations like ''Do the Right Thing''.',
        '1986',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Director'
    ),
    (
        17,
        'Robert Richardson',
        'Worked on ''Inglourious Basterds'' and ''Shutter Island''.',
        '1985',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Cinematographer'
    ),
    (
        18,
        'Trent Reznor',
        'Composer for films such as ''The Social Network'' and ''Gone Girl''.',
        '2008',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Composer'
    ),
    (
        19,
        'Sofia Coppola',
        'Director known for ''Lost in Translation'' and ''The Virgin Suicides''.',
        '1999',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Director'
    ),
    (
        20,
        'Michael Giacchino',
        'Known for his work on Pixar films and ''Jurassic World''.',
        '1997',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10',
        'Composer'
    );

SET
    IDENTITY_INSERT Crew OFF;

END