﻿-- Re-insert the data with improved tour names
INSERT INTO dbo.Tours (TourCode, TourName, FlightCode, HouseCode, IsOrgenized, Price, DestinationCode, StartDate, EndDate)
VALUES
(1, 'An amazing Tel-Aviv tour', 1, 21, 1, 1000.00, 100, '2024-07-23', '2024-07-30'),
(2, 'An amazing New York tour', 2, 41, 1, 1500.00, 110, '2024-08-02', '2024-08-09'),
(3, 'Discover New York', 3, 61, 1, 1200.00, 120, '2024-08-06', '2024-08-13'),
(4, 'Discover London', 5, 81, 1, 1800.00, 130, '2024-07-22', '2024-07-29'),
(5, 'A wonderful Paris adventure', 7, 101, 1, 1700.00, 140, '2024-08-12', '2024-08-19'),
(6, 'Explore Rome', 9, 121, 1, 1500.00, 150, '2024-07-19', '2024-07-26'),
(7, 'Discover Tokyo', 11, 141, 1, 2000.00, 160, '2024-08-12', '2024-08-19'),
(8, 'An amazing Sydney tour', 13, 161, 1, 1400.00, 170, '2024-08-09', '2024-08-16'),
(9, 'Explore Barcelona', 15, 181, 1, 1600.00, 180, '2024-08-09', '2024-08-16'),
(10, 'Discover Berlin', 17, 201, 1, 1500.00, 190, '2024-08-07', '2024-08-14'),
(11, 'An amazing Toronto tour', 19, 221, 1, 1400.00, 200, '2024-08-04', '2024-08-11'),
(12, 'Discover Amsterdam', 21, 241, 1, 1600.00, 210, '2024-08-10', '2024-08-17'),
(13, 'Explore Beijing', 23, 261, 1, 1500.00, 220, '2024-08-06', '2024-08-13'),
(14, 'An amazing Rio de Janeiro tour', 25, 281, 1, 1800.00, 230, '2024-08-10', '2024-08-17'),
(15, 'Explore Moscow', 27, 301, 1, 1700.00, 240, '2024-07-27', '2024-08-03'),
(16, 'Discover New Delhi', 29, 321, 1, 1600.00, 250, '2024-07-29', '2024-08-05'),
(17, 'An amazing Mexico City tour', 31, 341, 1, 1500.00, 260, '2024-07-20', '2024-07-27'),
(18, 'Explore Istanbul', 33, 361, 1, 1600.00, 270, '2024-07-16', '2024-07-23'),
(19, 'Discover Dubai', 35, 381, 1, 2000.00, 280, '2024-07-22', '2024-07-29'),
(20, 'An amazing Cape Town tour', 37, 401, 1, 1800.00, 290, '2024-08-07', '2024-08-14'),
(21, 'Explore Bangkok', 39, 421, 1, 1700.00, 300, '2024-08-08', '2024-08-15'),
(22, 'Discover Athens', 41, 441, 1, 1600.00, 310, '2024-07-26', '2024-08-02'),
(23, 'An amazing Singapore tour', 43, 461, 1, 1500.00, 320, '2024-07-26', '2024-08-02'),
(24, 'Explore Kuala Lumpur', 45, 481, 1, 1600.00, 330, '2024-07-25', '2024-08-01'),
(25, 'Discover Buenos Aires', 47, 501, 1, 1700.00, 340, '2024-08-13', '2024-08-20'),
(26, 'An amazing Seoul tour', 49, 521, 1, 1500.00, 350, '2024-08-09', '2024-08-16'),
(27, 'Explore Stockholm', 51, 541, 1, 1600.00, 360, '2024-07-24', '2024-07-31'),
(28, 'Discover Zurich', 53, 561, 1, 1800.00, 370, '2024-07-29', '2024-08-05'),
(29, 'An amazing Vienna tour', 55, 581, 1, 1700.00, 380, '2024-08-09', '2024-08-16'),
(30, 'Explore Brussels', 57, 601, 1, 1600.00, 390, '2024-07-25', '2024-08-01'),
(31, 'Discover Lisbon', 59, 621, 1, 1500.00, 400, '2024-08-10', '2024-08-17'),
(32, 'An amazing Cairo tour', 61, 641, 1, 1700.00, 410, '2024-07-21', '2024-07-28'),
(33, 'Explore Oslo', 63, 661, 1, 1800.00, 420, '2024-07-17', '2024-07-24'),
(34, 'Discover Copenhagen', 65, 681, 1, 1600.00, 430, '2024-08-01', '2024-08-08'),
(35, 'An amazing Helsinki tour', 67, 701, 1, 1700.00, 440, '2024-08-10', '2024-08-17'),
(36, 'Explore Warsaw', 69, 721, 1, 1500.00, 450, '2024-07-25', '2024-08-01'),
(37, 'Discover Dublin', 71, 741, 1, 1800.00, 460, '2024-07-24', '2024-07-31'),
(38, 'An amazing Prague tour', 73, 761, 1, 1600.00, 470, '2024-08-04', '2024-08-11'),
(39, 'Explore Budapest', 75, 781, 1, 1700.00, 480, '2024-08-06', '2024-08-13'),
(40, 'Discover Auckland', 77, 801, 1, 1500.00, 490, '2024-08-05', '2024-08-12'),
(41, 'An amazing Santiago tour', 79, 821, 1, 1800.00, 500, '2024-08-12', '2024-08-19'),
(42, 'Explore Bogota', 81, 841, 1, 1600.00, 510, '2024-08-04', '2024-08-11'),
(43, 'Discover Riyadh', 83, 861, 1, 1700.00, 520, '2024-08-05', '2024-08-12'),
(44, 'An amazing Jakarta tour', 85, 901, 1, 1500.00, 540, '2024-08-05', '2024-08-12'),
(45, 'Explore Hanoi', 89, 921, 1, 1600.00, 550, '2024-08-12', '2024-08-19');

