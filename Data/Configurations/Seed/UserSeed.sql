IF NOT EXISTS (SELECT 1 FROM [User])
BEGIN
SET
    IDENTITY_INSERT [User] ON;

INSERT INTO
    [User] (
        Id,
        UserName,
        Email,
        Password,
        Role,
        Bio,
        Gender,
        Active,
        Subscribed,
        CanResetPassword
    )
VALUES
    (
        1,
        'admin22',
        'admin@yahoo.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        0,
        'Admin bio test',
        0,
        1,
        0,
        0
    ),
    (
        2,
        'test1',
        'test1@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 1 bio test',
        0,
        1,
        0,
        0
    ),
    (
        3,
        'test2',
        'test2@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 2 bio test',
        0,
        1,
        0,
        0
    ),
    (
        4,
        'test3',
        'test3@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 3 bio test',
        0,
        1,
        0,
        0
    ),
    (
        5,
        'test4',
        'test4@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 4 bio test',
        0,
        1,
        0,
        0
    ),
    (
        6,
        'test5',
        'test5@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 5 bio test',
        0,
        1,
        0,
        0
    ),
    (
        7,
        'test6',
        'test6@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 6 bio test',
        0,
        1,
        0,
        0
    ),
    (
        8,
        'test7',
        'test7@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 7 bio test',
        0,
        1,
        0,
        0
    ),
    (
        9,
        'test8',
        'test8@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 8 bio test',
        0,
        1,
        0,
        0
    ),
    (
        10,
        'test9',
        'test9@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 9 bio test',
        0,
        1,
        0,
        0
    ),
    (
        11,
        'test10',
        'test10@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 10 bio test',
        0,
        1,
        0,
        0
    ),
    (
        12,
        'test11',
        'test11@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 11 bio test',
        0,
        1,
        0,
        0
    ),
    (
        13,
        'test12',
        'test12@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 12 bio test',
        0,
        1,
        0,
        0
    ),
    (
        14,
        'test13',
        'test13@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 13 bio test',
        0,
        1,
        0,
        0
    ),
    (
        15,
        'test14',
        'test14@email.com',
        '$2a$12$LIkI5Cs1ADMlIzSgIKJ9keFi8VGEW6uNT1Y.6OHzKRHWMvSCmFKCO',
        1,
        'Test 14 bio test',
        0,
        1,
        0,
        0
    );

SET
    IDENTITY_INSERT [User] OFF;

END
