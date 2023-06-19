CREATE DATABASE STGenetics;

USE STGenetics;

CREATE TABLE Breed (
  BreedId INT PRIMARY KEY IDENTITY(1,1),
  BreedName NVARCHAR(255)
);

CREATE TABLE Animal (
  AnimalId INT PRIMARY KEY IDENTITY(1,1),
  [Name] NVARCHAR(255),
  BreedId INT,
  BirthDate DATE,
  Sex NVARCHAR(20),
  Price DECIMAL(10,2),
  [Status] BIT,
  Photo NVARCHAR(MAX),
  FOREIGN KEY (BreedId) REFERENCES Breed(BreedId)
);

INSERT INTO Breed (BreedName) VALUES
('Angus'),
('Hereford'),
('Charolais'),
('Limousin'),
('Simmental'),
('Holstein'),
('Jersey'),
('Brown Swiss'),
('Guernsey'),
('Aberdeen Angus'),
('Brahman'),
('Hereford Crossbreed'),
('Gelbvieh'),
('Shorthorn'),
('Wagyu');

-- Insert Animal rows
INSERT INTO Animal (Name, BreedId, BirthDate, Sex, Price, Status, Photo)
VALUES
  ('Sparkle', 2, '2020-01-15', 'Female', 2259500.00, 1, 'https://petkeen.com/wp-content/uploads/2021/12/Hereford-Cattle-in-the-field_Scott-Allan_Shutterstock-760x507.jpg'),
  ('Midnight', 4, '2018-03-22', 'Male', 1500780.00, 1, 'https://secure.ganaderia.com/razas/Raza609aca206a773_11052021.jpeg'),
  ('Cocoa', 3, '2014-05-07', 'Female', 2620000.00, 0, 'https://www.howecoulee.ca/uploads/2/8/6/5/28655389/skw-140c_orig.jpg'),
  ('Rusty', 1, '2016-07-12', 'Male', 1770010.00, 1, 'https://secure.ganaderia.com/razas/Raza593184b741af4_02062017.jpg'),
  ('Moonbeam', 5, '2019-09-01', 'Female', 1000840.00, 0, 'https://revistageneticabovina.com/wp-content/uploads/2020/10/S1.png'),
  ('Whiskers', 2, '2020-11-11', 'Male', 2300560.00, 1, 'https://secure.ganaderia.com/razas/Raza593194353d2bf_02062017.jpg'),
  ('Blossom', 3, '2028-02-14', 'Female', 3002920.00, 1, 'https://ruminants.ceva.pro/hubfs/vacas-blancas.jpg'),
  ('Champ', 4, '2019-04-20', 'Male', 1907900.00, 0, 'https://i0.wp.com/agroexport.agr.br/wp-content/uploads/2021/01/limousin-1.jpg'),
  ('Butterscotch', 1, '2017-06-30', 'Female', 1681000.00, 1, 'https://upload.wikimedia.org/wikipedia/commons/5/57/Angus_cattle_10.jpg'),
  ('Sundance', 5, '2015-08-09', 'Male', 1985890.00, 0, 'https://www.pregonagropecuario.com/assets/images/upload/toro_simmental.jpg'),
  ('Luna', 1, '2019-09-18', 'Female', 3058950.00, 1, 'https://zoovetesmipasion.com/wp-content/uploads/2023/03/image-35.png'),
  ('Maximus', 2, '2018-07-05', 'Male', 1600780.00, 1, 'https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Hereford_bull_large.jpg/500px-Hereford_bull_large.jpg'),
  ('Coco', 3, '2016-01-12', 'Female', 5200620.00, 0, 'https://www.gdbulls.com/img/cms/AA-Contenu-Edito-GD-Bulls/02-Races-Allaitantes/D2-mere-et-son-veau-charolais.jpg'),
  ('Leo', 4, '2017-03-19', 'Male', 1500710.00, 1, 'https://www.pregonagropecuario.com/assets/images/upload/toro_limousin.jpg'),
  ('Stella', 5, '2018-05-25', 'Female', 2000840.00, 0, 'https://britishsimmental.co.uk/wp-content/uploads/2022/01/Slievenagh-Klassy-Lady-1024x684.jpg'),
  ('Rocky', 2, '2019-08-02', 'Male', 2500560.00, 1, 'https://www.pregonagropecuario.com/assets/images/upload/toro_hereford_.jpg'),
  ('Bella', 3, '2021-10-14', 'Female', 2900020.00, 1, 'https://www.agro21.net/wp-content/uploads/2022/04/Fotos-destacadas-para-blog-Agro21-wordpress-32.jpg'),
  ('Milo', 4, '2018-12-31', 'Male', 1500790.00, 0, 'https://upload.wikimedia.org/wikipedia/commons/3/31/Limousin_bull.jpg'),
  ('Lily', 1, '2020-02-08', 'Female', 1500680.00, 1, 'https://harrys.com.mx/wp-content/uploads/2019/08/image001-820x450.jpg'),
  ('Zeus', 5, '2019-04-17', 'Male', 3150890.00, 0, 'https://www.centroelremanso.org/wp-content/uploads/2017/07/SIMMENTAL_3-555x370.jpg'),
  ('Simba', 3, '2018-05-15', 'Male', 3500800.00, 1, 'https://upload.wikimedia.org/wikipedia/commons/1/1c/Taureau_charolais.jpg'),
  ('Luna', 1, '2017-08-20', 'Female', 4150050.00, 1, 'https://anguslassuertesdelmonte.com/wp-content/uploads/2022/05/origen-carne-angus-prueba.jpg'),
  ('Max', 2, '2019-03-05', 'Male', 1500700.00, 0, 'https://news.agrofystatic.com/hereford_raza_agrofy_news.jpg'),
  ('Bella', 4, '2020-01-12', 'Female', 3150750.00, 1, 'https://www.gdbulls.com/img/cms/AA-Contenu-Edito-GD-Bulls/02-Races-Allaitantes/D6-mere-et-son-veau.jpg'),
  ('Rocky', 5, '2017-12-03', 'Male', 2150900.00, 1, 'https://zoovetesmipasion.com/wp-content/uploads/2023/03/image-44.png'),
  ('Molly', 3, '2019-09-10', 'Female', 1500600.00, 0, 'https://www.howecoulee.ca/uploads/2/8/6/5/28655389/skw-140c_orig.jpg'),
  ('Charlie', 2, '2018-02-28', 'Male', 3150850.00, 1, 'https://zoovetesmipasion.com/wp-content/uploads/2016/07/Ganado-Hereford.png'),
  ('Daisy', 4, '2020-07-08', 'Female', 2150070.00, 0, 'https://www.miguelvergara.com/actualidad/wp-content/uploads/2021/06/limousin-raza.jpg'),
  ('Buddy', 1, '2017-06-17', 'Male', 1500780.00, 1, 'https://cdn.britannica.com/39/76939-050-B787E5BF/bull-Black-Angus.jpg'),
  ('Lola', 5, '2019-11-22', 'Female', 1500920.00, 1, 'https://carnescamponatura.com/wp-content/uploads/2021/08/vaca-simmental.jpg');

