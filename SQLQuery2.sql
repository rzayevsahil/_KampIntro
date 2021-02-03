--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City='Berlin'

--case insensitive duyarsızlığı
select * from Products where CategoryId=1 or CategoryId=3

select * from Products where CategoryId=1 and UnitPrice>=10

--categroryId içindeki her bir productName leri de ismine göre sıralıyoruz Select * from Products order by CategoryID,ProductName asc 
Select * from Products where CategoryID=1 order by UnitPrice desc  --ascendig-artan ---desc desceding-artan,düşen

select count(*) Adet from Products 

--select count(*) Adet from Products group by CategoryID

select CategoryID,count(*) from Products where UnitPrice>20  group by CategoryID
--where UnitPrice>20 diyince azaldı sayısı 10dan küçüktür diye artmış oldu veri sayısı
select CategoryID,count(*) from Products where UnitPrice>20  group by CategoryID having count(*)<10

--inner join sadece 2 tabloda da eşleşenleri göre bilir,eşleşmeyen data varsa onu getirmez
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories --inner join bir araya getiriyor
on Products.CategoryID=Categories.CategoryID	
where Products.UnitPrice>10

--DTO Data Transformation Object

select * from Products p inner join [Order Details] od--boşluk doğru standarta uymadığı için köşeli paranteze alınır
on p.ProductID=od.ProductID  --2155

select * from Products p left join [Order Details] od --solda olup sağda olmayanı getir, yani satılmayan ürünleri getir(sonuç ise hepsini satmışım)
on p.ProductID=od.ProductID  --2155   --genellikle bu kullanılır

select * from Customers c inner join Orders o --830
on c.CustomerID=o.CustomerID

select * from Customers c left join Orders o  --832 , soldakı kayıtları sağdakıyla uyuşmasa bile getirir
on c.CustomerID=o.CustomerID

select * from Customers c left join Orders o  --sistemimize kayıt olmuş ama sipariş almamış kişileri getirip onlara özel kampanya yollamak
on c.CustomerID=o.CustomerID                  --2
where o.CustomerID is null    --genellikler bu kullanılır

select * from Products p inner join [Order Details] od  --ikiden fazla tabloyu join etmek için
on p.ProductID=od.ProductID 
inner join Orders o
on o.OrderID=od.OrderID


--Ödev sorusu Her bir üründen toplamda ne kadar para kazandığımızı bulunuz.
/*İpucu : Group by kullanılacak
İpucu : Products, Orders, Order Details tabloları join edilecek.
İpucu : Sum kullanılacak.
Sonuç aşağıdaki formatta olmalıdır.
Ürün Adı, Kazanılan Toplam Miktar
Not : Kazanılan tutar toplamı Order Details tablosunda unitPrice ve quantity alanlarının çarpımından beslenecek.*/

select p.ProductName ÜrünAdı, SUM(od.UnitPrice * od.Quantity) KazanılanToplamMiktar from Products p inner join [Order Details] od  --ikiden fazla tabloyu join etmek için
on p.ProductID=od.ProductID 
inner join Orders o
on o.OrderID=od.OrderID group by p.ProductName










