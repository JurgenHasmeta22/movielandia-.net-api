IF EXISTS (SELECT 1 FROM UserGenreFavorite) DELETE FROM UserGenreFavorite;
IF EXISTS (SELECT 1 FROM UserMovieFavorite) DELETE FROM UserMovieFavorite;
IF EXISTS (SELECT 1 FROM UserMovieRating) DELETE FROM UserMovieRating;
IF EXISTS (SELECT 1 FROM MovieReview) DELETE FROM MovieReview;
IF EXISTS (SELECT 1 FROM CastMovie) DELETE FROM CastMovie;
IF EXISTS (SELECT 1 FROM MovieGenre) DELETE FROM MovieGenre;
IF EXISTS (SELECT 1 FROM [User]) DELETE FROM [User];
IF EXISTS (SELECT 1 FROM Movie) DELETE FROM Movie;
IF EXISTS (SELECT 1 FROM Actor) DELETE FROM Actor;
IF EXISTS (SELECT 1 FROM Genre) DELETE FROM Genre;

-- Genres
SET IDENTITY_INSERT Genre ON;
INSERT INTO Genre (Id, Name) VALUES
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
(20, 'Biography');
SET IDENTITY_INSERT Genre OFF;

-- Actors
SET IDENTITY_INSERT Actor ON;
INSERT INTO Actor (Id, Fullname, Description, Debut, PhotoSrc, PhotoSrcProd, CreatedAt) VALUES
(1, 'Tom Holland', 'Thomas Stanley Holland is an English actor. His accolades include a British Academy Film Award and three Saturn Awards.', '2012', 'http://localhost:4000/images/actors/tom-holland.jpg', 'https://movielandia-avenger22s-projects.vercel.app/images/actors/tom-holland.jpg', '2025-04-10'),
(2, 'Robert Downey Jr.', 'Robert John Downey Jr. is an American actor and producer. His career has been characterized by critical and popular success in his youth.', '1970', 'http://localhost:4000/images/actors/robert-downey-jr.jpg', 'https://movielandia-avenger22s-projects.vercel.app/images/actors/robert-downey-jr.jpg', '2025-04-10'),
(3, 'Leonardo DiCaprio', 'Leonardo Wilhelm DiCaprio is an American actor and film producer known for his work in biopics and period films.', '1991', 'http://localhost:4000/images/actors/leonardo-dicaprio.jpg', 'https://movielandia-avenger22s-projects.vercel.app/images/actors/leonardo-dicaprio.jpg', '2025-04-10');
SET IDENTITY_INSERT Actor OFF;

-- Movies
SET IDENTITY_INSERT Movie ON;
INSERT INTO Movie (Id, Title, PhotoSrc, PhotoSrcProd, TrailerSrc, Duration, RatingImdb, DateAired, Description) VALUES
(1, 'Spider-Man: No Way Home', 
'http://localhost:4000/images/movies/spider-man-no-way-home.jpg',
'https://movielandia-avenger22s-projects.vercel.app/images/movies/spider-man-no-way-home.jpg',
'https://www.youtube.com/embed/JfVOs4VSpmA',
148,
8.2,
'2021-12-17',
'With Spider-Man''s identity now revealed, Peter asks Doctor Strange for help. When a spell goes wrong, dangerous foes from other worlds start to appear, forcing Peter to discover what it truly means to be Spider-Man.'),
(2, 'Iron Man',
'http://localhost:4000/images/movies/iron-man.jpg',
'https://movielandia-avenger22s-projects.vercel.app/images/movies/iron-man.jpg',
'https://www.youtube.com/embed/8ugaeA-nMTc',
126,
7.9,
'2008-05-02',
'After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.'),
(3, 'Inception',
'http://localhost:4000/images/movies/inception.jpg',
'https://movielandia-avenger22s-projects.vercel.app/images/movies/inception.jpg',
'https://www.youtube.com/embed/YoHD9XEInc0',
148,
8.8,
'2010-07-16',
'A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.');
SET IDENTITY_INSERT Movie OFF;

-- Movie Genres
SET IDENTITY_INSERT MovieGenre ON;
INSERT INTO MovieGenre (Id, MovieId, GenreId) VALUES
(1, 1, 1),  -- Spider-Man: Action
(2, 1, 4),  -- Spider-Man: Science Fiction
(3, 1, 10), -- Spider-Man: Fantasy
(4, 2, 1),  -- Iron Man: Action
(5, 2, 4),  -- Iron Man: Science Fiction
(6, 2, 11), -- Iron Man: Adventure
(7, 3, 1),  -- Inception: Action
(8, 3, 4),  -- Inception: Science Fiction
(9, 3, 12); -- Inception: Mystery
SET IDENTITY_INSERT MovieGenre OFF;

-- Cast in Movies
SET IDENTITY_INSERT CastMovie ON;
INSERT INTO CastMovie (Id, MovieId, ActorId) VALUES
(1, 1, 1), -- Tom Holland in Spider-Man: No Way Home
(2, 2, 2), -- Robert Downey Jr. in Iron Man
(3, 3, 3); -- Leonardo DiCaprio in Inception
SET IDENTITY_INSERT CastMovie OFF;

-- Sample User
SET IDENTITY_INSERT [User] ON;
INSERT INTO [User] (Id, UserName, Email, Password, Role, Bio, Gender, Phone, CountryFrom, Active, Subscribed, CanResetPassword) VALUES
(1, 'admin', 'admin@movielandia.com', 'hashed_password_here', 0, 'System Administrator', 0, '+11234567890', 'United States', 1, 0, 0),
(2, 'moviebuff', 'moviebuff@example.com', 'hashed_password_here', 1, 'Passionate about movies', 0, '+11234567891', 'Canada', 1, 0, 0),
(3, 'cinephile', 'cinephile@example.com', 'hashed_password_here', 1, 'Love analyzing films', 1, '+11234567892', 'United Kingdom', 1, 0, 0);
SET IDENTITY_INSERT [User] OFF;

-- Sample Movie Reviews
SET IDENTITY_INSERT MovieReview ON;
INSERT INTO MovieReview (Id, Content, Rating, CreatedAt, UserId, MovieId) VALUES
(1, 'One of the best Spider-Man movies ever made!', 5.0, '2025-04-23', 1, 1),
(2, 'A groundbreaking superhero film that started it all.', 4.5, '2025-04-23', 2, 2),
(3, 'Mind-bending masterpiece that keeps you thinking.', 5.0, '2025-04-23', 3, 3);
SET IDENTITY_INSERT MovieReview OFF;

-- Sample Movie Ratings
SET IDENTITY_INSERT UserMovieRating ON;
INSERT INTO UserMovieRating (Id, Rating, UserId, MovieId) VALUES
(1, 5.0, 1, 1),
(2, 4.5, 2, 2),
(3, 5.0, 3, 3);
SET IDENTITY_INSERT UserMovieRating OFF;

-- Sample Movie Favorites
SET IDENTITY_INSERT UserMovieFavorite ON;
INSERT INTO UserMovieFavorite (Id, UserId, MovieId) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3);
SET IDENTITY_INSERT UserMovieFavorite OFF;

-- Sample Genre Favorites
SET IDENTITY_INSERT UserGenreFavorite ON;
INSERT INTO UserGenreFavorite (Id, UserId, GenreId) VALUES
(1, 1, 1),  -- Admin likes Action
(2, 1, 4),  -- Admin likes Sci-Fi
(3, 2, 10), -- MovieBuff likes Fantasy
(4, 3, 2);  -- Cinephile likes Drama
SET IDENTITY_INSERT UserGenreFavorite OFF;