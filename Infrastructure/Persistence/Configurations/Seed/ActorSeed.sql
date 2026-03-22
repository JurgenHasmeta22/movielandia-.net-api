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
        CreatedAt
    )
VALUES
    (
        1,
        'Tom Holland',
        'Thomas Stanley Holland is an English actor. His accolades include a British Academy Film Award and three Saturn Awards.',
        '2012',
        'http://localhost:4000/images/actors/tom-holland.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/actors/tom-holland.jpg',
        '2025-04-10'
    ),
    (
        2,
        'Zendaya',
        'Zendaya Maree Stoermer Coleman is an American actress and singer who has received various accolades.',
        '2010',
        'http://localhost:4000/images/actors/zendaya.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/actors/zendaya.jpg',
        '2025-04-10'
    ),
    (
        3,
        'Benedict Cumberbatch',
        'Benedict Timothy Carlton Cumberbatch CBE is an English actor known for his work on screen and stage.',
        '2000',
        'http://localhost:4000/images/actors/benedict-cumberbatch.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/actors/benedict-cumberbatch.jpg',
        '2025-04-10'
    ),
    (
        4,
        'Mackenzie Davis',
        'A brief description for Mackenzie Davis.',
        '2012',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        5,
        'Finn Wolfhard',
        'A brief description for Finn Wolfhard.',
        '2014',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        6,
        'Brooklynn Prince',
        'A brief description for Brooklynn Prince.',
        '2015',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        7,
        'Leighton Meester',
        'A brief description for Leighton Meester.',
        '1999',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        8,
        'Christina Wolfe',
        'A brief description for Christina Wolfe.',
        '2013',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        9,
        'Damson Idris',
        'A brief description for Damson Idris.',
        '2010',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        10,
        'Carter Hudson',
        'A brief description for Carter Hudson.',
        '2007',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        11,
        'Giorgio Cantarini',
        'A brief description for Giorgio Cantarini.',
        '1999',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        12,
        'Aurora Quattrocchi',
        'A brief description for Aurora Quattrocchi.',
        '2005',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        13,
        'Franz Rogowski',
        'A brief description for Franz Rogowski.',
        '2009',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        14,
        'Gokhan Yikilkan',
        'A brief description for Gokhan Yikilkan.',
        '2011',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        15,
        'Belçim Bilgin',
        'A brief description for Belçim Bilgin.',
        '2006',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        16,
        'Bariş Arduc',
        'A brief description for Bariş Arduc.',
        '2010',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        17,
        'Mario Casas',
        'A brief description for Mario Casas.',
        '2006',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        18,
        'Ana Wagener',
        'A brief description for Ana Wagener.',
        '2001',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        19,
        'José Coronado',
        'A brief description for José Coronado.',
        '1996',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        20,
        'Michael Jai White',
        'A brief description for Michael Jai White.',
        '1992',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        21,
        'Julian Sands',
        'A brief description for Julian Sands.',
        '1984',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        22,
        'Eamonn Walker',
        'A brief description for Eamonn Walker.',
        '1994',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        23,
        'Jacob Tremblay',
        'A brief description for Jacob Tremblay.',
        '2013',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        24,
        'Julia Roberts',
        'A brief description for Julia Roberts.',
        '1987',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        25,
        'Owen Wilson',
        'A brief description for Owen Wilson.',
        '1996',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        26,
        'Gemma Chan',
        'A brief description for Gemma Chan.',
        '2006',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        27,
        'Richard Madden',
        'A brief description for Richard Madden.',
        '2007',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        28,
        'Kumail Nanjiani',
        'A brief description for Kumail Nanjiani.',
        '2008',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        29,
        'Asim Chaudhry',
        'A brief description for Asim Chaudhry.',
        '2011',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        30,
        'Kobna Holdbrook-Smith',
        'A brief description for Kobna Holdbrook-Smith.',
        '2008',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        31,
        'Giovanna Mezzogiorno',
        'A brief description for Giovanna Mezzogiorno.',
        '1997',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        32,
        'Stefano Accorsi',
        'A brief description for Stefano Accorsi.',
        '1996',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        33,
        'Amanda Collin',
        'A brief description for Amanda Collin.',
        '2010',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        34,
        'Dar Salim',
        'A brief description for Dar Salim.',
        '2009',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        35,
        'Noomi Rapace',
        'A brief description for Noomi Rapace.',
        '2000',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        36,
        'Joel Kinnaman',
        'A brief description for Joel Kinnaman.',
        '2003',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        37,
        'Kevin Hart',
        'A brief description for Kevin Hart.',
        '2001',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        38,
        'John Cena',
        'A brief description for John Cena.',
        '2000',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        39,
        'Danielle Brooks',
        'A brief description for Danielle Brooks.',
        '2011',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        40,
        'Ashley Walters',
        'A brief description for Ashley Walters.',
        '2000',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        41,
        'Kane Robinson',
        'A brief description for Kane Robinson.',
        '2005',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        42,
        'Micheal Ward',
        'A brief description for Micheal Ward.',
        '2014',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        43,
        'Samy Seghir',
        'A brief description for Samy Seghir.',
        '2011',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        44,
        'Manon Azem',
        'A brief description for Manon Azem.',
        '2009',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        45,
        'Tracy Gotoas',
        'A brief description for Tracy Gotoas.',
        '2003',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        46,
        'Jason Bateman',
        'A brief description for Jason Bateman.',
        '1987',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        47,
        'Laura Linney',
        'A brief description for Laura Linney.',
        '1993',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        48,
        'Sofia Hublitz',
        'A brief description for Sofia Hublitz.',
        '2013',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        49,
        'Alan Tudyk',
        'A brief description for Alan Tudyk.',
        '2000',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    ),
    (
        50,
        'Sara Tomko',
        'A brief description for Sara Tomko.',
        '2011',
        'http://localhost:4000/images/placeholder.jpg',
        'https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg',
        '2025-04-10'
    );

SET
    IDENTITY_INSERT Actor OFF;

END