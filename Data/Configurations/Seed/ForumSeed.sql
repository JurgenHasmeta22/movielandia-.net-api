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
        'General Discussion',
        'General discussions about movies, TV shows, and the entertainment industry.'
    ),
    (
        2,
        'Movies Discussion',
        'Discuss your favorite movies, upcoming releases, and movie news.'
    ),
    (
        3,
        'TV Series Discussion',
        'Talk about TV series, episodes, seasons, and streaming shows.'
    ),
    (
        4,
        'Actors & Crew',
        'Discussions about actors, directors, writers, and other crew members.'
    ),
    (
        5,
        'Reviews & Ratings',
        'Share your reviews and ratings of movies and TV shows.'
    ),
    (
        6,
        'Recommendations',
        'Looking for something to watch? Get recommendations here.'
    ),
    (
        7,
        'News & Announcements',
        'Latest news and announcements from the entertainment industry.'
    );

SET
    IDENTITY_INSERT ForumCategory OFF;

END IF NOT EXISTS (
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
    ),
    (
        9,
        'Behind the Scenes',
        'Behind the scenes information and trivia',
        '#795548'
    ),
    (
        10,
        'Help',
        'Help with using the MovieLandia platform',
        '#607D8B'
    ),
    (
        11,
        'Action',
        'Action movies and TV shows',
        '#E91E63'
    ),
    (
        12,
        'Comedy',
        'Comedy movies and TV shows',
        '#FFEB3B'
    ),
    (
        13,
        'Drama',
        'Drama movies and TV shows',
        '#3F51B5'
    ),
    (
        14,
        'Horror',
        'Horror movies and TV shows',
        '#000000'
    ),
    (
        15,
        'Sci-Fi',
        'Science fiction movies and TV shows',
        '#009688'
    ),
    (
        16,
        'Fantasy',
        'Fantasy movies and TV shows',
        '#8BC34A'
    ),
    (
        17,
        'Documentary',
        'Documentary movies and TV shows',
        '#FFC107'
    ),
    (
        18,
        'Animation',
        'Animated movies and TV shows',
        '#CDDC39'
    ),
    (
        19,
        'Thriller',
        'Thriller movies and TV shows',
        '#9E9E9E'
    ),
    (
        20,
        'Romance',
        'Romance movies and TV shows',
        '#E57373'
    );

SET
    IDENTITY_INSERT ForumTag OFF;

END