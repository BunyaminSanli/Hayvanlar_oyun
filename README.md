# Hayvanlar_oyun
 hayvan adında bir abstract class oluşturdum ve 4 hayvan için de ortak olan metotları ve özellikleri yazdım. Daha sonra her bir hayvan sınıfına 
 hayvan adlı abstract classtan kalıtım aldırarak metotları uygulattırdım. Can metodu keçi için eğer enerjisi 6 dan büyükse 6 birim azaltıyor 
 ancak 6dan küçükse 0’a eşitliyor çünkü 100 birimlik progressBar her saniye 6 birim azaldığından en son 4 birim can kalacaktır. 
 Bu yüzden biz bunu eğer 6’dan küçükse 0’a eşitleriz. Aynı fonksiyon diğer hayvanlarda da farklı birimleri alarak canları düşürür.
 UrunOlustur metodu her seferinde ürün değişkenini bir arttırır. yine keçi üzerinden örnek verecek olursak 7 saniyede bir süt vereceği için zamanın mod 7’si 
 eğer 0’a eşitse ve zamanın 7ye bölümü 0 değilse ve enerjisi de 0 değilse yani ölmemişse urun değişkeni bir arttırılır.
	
 UrunSat metodu ise buttonKeciSat butonuna tıklandığında çağrılır ve her birim süt için 8’le çarpılır ve para değişkenine atanır.
 Yemle metodu herhangi bir hayvanın canı 0 değilse o hayvanın canını 100 yapar eğer canı sıfırsa ölü olacağı için yemle metodu çalışmıyor.

