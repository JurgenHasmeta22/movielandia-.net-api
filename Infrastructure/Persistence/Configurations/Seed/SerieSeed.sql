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
        TrailerSrc,
        DateAired,
        RatingImdb
    )
VALUES
    (
        1,
        'Rebelde',
        'http://localhost:4000/images/series/rebelde.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/rebelde.jpg',
        'Rebelde follows the lives of students at Elite Way School, a prestigious private school in Mexico City.',
        'https://www.youtube.com/watch?v=BJYJksHREIc',
        '2004-01-05',
        6.3
    ),
    (
        2,
        'Snowfall',
        'http://localhost:4000/images/series/snowfall.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/snowfall.jpg',
        'Snowfall is an American television series created by John Singleton, Eric Amadio, and Dave Andron. The series is set in the early 1980s in Los Angeles and examines the early days of the crack cocaine epidemic and its impact.',
        'https://www.youtube.com/embed/BJYJksHREIc',
        '2017-07-05',
        8.2
    ),
    (
        3,
        'Man vs Bee',
        'http://localhost:4000/images/series/manbee.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/manbee.jpg',
        'Man vs Bee is a documentary series that explores the confrontation between plants and bees in our world.',
        'https://www.youtube.com/embed/BJYJksHREIc',
        '2022-06-24',
        6.8
    ),
    (
        4,
        'Moonknight',
        'http://localhost:4000/images/series/moonknight.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/moonknight.jpg',
        'Moonknight follows the adventures of Marc Spector, a former military man who gains powers from a mythological being.',
        'https://www.youtube.com/embed/x7Krla_UxRg',
        '2022-03-30',
        7.4
    ),
    (
        5,
        'Peacemaker',
        'http://localhost:4000/images/series/peacemaker.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/peacemaker.jpg',
        'Peacemaker is an American television series created by James Gunn for the DC Universe and HBO Max.',
        'https://www.youtube.com/embed/WHXq62VCaCM',
        '2022-01-13',
        8.3
    ),
    (
        6,
        'Top Boy',
        'http://localhost:4000/images/series/topboy.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/topboy.jpg',
        'Top Boy is a British television series created by Ronan Bennet. The series follows the lives of teenagers and those involved in drug trafficking in a poor neighborhood in London.',
        'https://www.youtube.com/embed/BYLYZ7OsymE',
        '2011-10-31',
        8.4
    ),
    (
        7,
        'Ganglands',
        'http://localhost:4000/images/series/ganglands.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/ganglands.jpg',
        'Ganglands is a French crime series based on the true story of a family running an organized crime gang in Paris.',
        'https://www.youtube.com/embed/0VZ2Nbx8gHI',
        '2021-09-24',
        7.0
    ),
    (
        8,
        'Ozark',
        'http://localhost:4000/images/series/ozark.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/ozark.jpg',
        'Ozark is an American drama series that follows the life of a family that develops a large money-laundering business in the Ozark Mountains in Missouri.',
        'https://www.youtube.com/embed/5hAXVqrljbs',
        '2017-07-21',
        8.5
    ),
    (
        9,
        'Resident Alien',
        'http://localhost:4000/images/series/alien.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/alien.jpg',
        'Resident Alien is an American sci-fi comedy series that follows an extraterrestrial trying to escape his secret identity by living as a doctor in a small American town.',
        'https://www.youtube.com/embed/T4J7QjGNTs4',
        '2021-01-27',
        8.1
    ),
    (
        10,
        'Bridgerton',
        'http://localhost:4000/images/series/bridgerton.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/bridgerton.jpg',
        'Bridgerton is a British-American historical drama series created by Chris Van Dusen and produced by Shonda Rhimes. The series follows the lives of the Bridgerton family in London from 1813-1827.',
        'https://www.youtube.com/embed/U4JYAx5rNRA',
        '2020-12-25',
        7.3
    ),
    (
        11,
        'Superman and Lois',
        'http://localhost:4000/images/series/superman.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/superman.jpg',
        'Superman & Lois is an American superhero television series based on the DC Comics characters Superman and Lois Lane. The series follows the lives of Superman and Lois Lane after their marriage, facing challenges in both their personal lives and their profession as superheroes.',
        'https://www.youtube.com/embed/SJPJPUpNvDw',
        '2021-02-23',
        7.8
    ),
    (
        12,
        'Attack on Titan',
        'http://localhost:4000/images/series/aot.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/aot.png',
        'Attack on Titan is a Japanese anime series based on the manga of the same name written by Hajime Isayama. The series follows the story of a world where human civilization is threatened by giant creatures known as Titans.',
        'https://www.youtube.com/embed/MGRm4IzK1SQ',
        '2013-04-07',
        9.0
    ),
    (
        13,
        'Kengan Ashura',
        'http://localhost:4000/images/series/baki.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/baki.png',
        'Kengan Ashura is a Japanese anime series based on the manga of the same name written by Yabako Sandrovich. The series follows the story of Tokita Ohma, a young fighter involved in a combat tournament called Kengan to dominate the business of firms.',
        'https://www.youtube.com/embed/CNuY4ymi4Fs',
        '2019-07-31',
        8.0
    ),
    (
        14,
        'Elite',
        'http://localhost:4000/images/series/elite.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/elite.png',
        'Elite is a Spanish series created by Carlos Montero and Darío Madrona. The series follows the lives of students at a high-end private school in Spain, where tragic events and various secrets come to light.',
        'https://www.youtube.com/embed/QNwhAdrdwp0',
        '2018-10-05',
        7.4
    ),
    (
        15,
        'The Flash',
        'http://localhost:4000/images/series/flash.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/flash.png',
        'The Flash is an American superhero television series created by Greg Berlanti, Andrew Kreisberg, and Geoff Johns, based on the DC Comics character of the same name. The series follows the adventures of Barry Allen, a forensic scientist who gains the ability to move at incredible speeds after a lab accident.',
        'https://www.youtube.com/embed/hebWYacbdvc',
        '2014-10-07',
        7.6
    ),
    (
        16,
        'Power Book IV Force',
        'http://localhost:4000/images/series/force.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/force.png',
        'Power Book IV: Force is an American drama series created by Courtney A. Kemp for Starz. The series follows the life of Tommy Egan, a character first introduced in the series "Power", as he becomes involved in the world of organized crime in Chicago.',
        'https://www.youtube.com/embed/uiGzLrJSk8E',
        '2022-02-06',
        8.1
    ),
    (
        17,
        'Halo',
        'http://localhost:4000/images/series/halo.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/halo.png',
        'Halo is an American sci-fi television series created by Kyle Killen and Steven Kane. Based on the popular "Halo" video game by Microsoft Studios, the series follows the adventures of Master Chief, a super-soldier called upon to protect a harsh world from the threat of an alien alliance known as the Covenant.',
        'https://www.youtube.com/embed/5KZ3MKraNKY',
        '2022-03-24',
        7.0
    ),
    (
        18,
        'The Last Kingdom',
        'http://localhost:4000/images/series/kingdom.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/kingdom.png',
        'The Last Kingdom is a British historical series created by Stephen Butchard. Based on the "Saxon Stories" novels by Bernard Cornwell, the series follows the adventures of Uhtred Ragnarson, a Saxon boy who attempts to defend and reclaim his territory in Middle Britain in the 9th century.',
        'https://www.youtube.com/embed/BJYJksHREIc',
        '2015-10-10',
        8.5
    ),
    (
        19,
        'Knightfall',
        'http://localhost:4000/images/series/knightfall.png',
        'https://movielandia-avenger22s-projects.vercel.app/images/series/knightfall.png',
        'Knightfall is an American historical drama series created by Don Handfield and Richard Rayner for the History Channel. The series follows the rise and fall of the Knights Templar, beginning with its foundation in post-war Selma, Alabama, in 1865, to its suppression in 1871.',
        'https://www.youtube.com/embed/F9dtepkeR0I',
        '2017-12-06',
        6.7
    );

SET
    IDENTITY_INSERT Serie OFF;

END