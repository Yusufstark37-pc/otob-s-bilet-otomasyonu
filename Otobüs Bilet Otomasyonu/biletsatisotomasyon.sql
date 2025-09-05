create database biletsatisotomasyonu;


CREATE TABLE seferbilgileri (
    Sefer_Id INT AUTO_INCREMENT PRIMARY KEY,
    MusteriAd VARCHAR(50),
    MusteriSoyad VARCHAR(50),
    Telefon VARCHAR(15),
    Cinsiyet VARCHAR(30),
    FirmaAdi VARCHAR(50),
    SeferBaslangic VARCHAR(50),
    SeferBitis VARCHAR(50),
    KoltukNo INT,
    Tarih DATETIME,
    Fiyat INT
);

TRUNCATE TABLE seferbilgileri;