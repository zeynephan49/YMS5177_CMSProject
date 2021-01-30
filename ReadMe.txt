
Documantation
1. YMS5177_CMS adında boş bir solution eklenir.
2. Solution altına Class Library (.Net Core) proje tipinde YMS5177_CMS.Entity adında bir proje eklenir.
	2.1. Aşağıdaki paketleri yükleyiniz.
		2.1.1. Microsoft.AspNetCore.Http.Features
		2.1.2. Microsoft.Extensions.Identity.Stores
	2.2. Enums klasörü açılır. Status.cs sınıfı enum tipinde eklneir.
	2.3. Entities klasörü açılır.
		2.3.1. Interfaces klasörü açılır. IBaseEntity.cs sınıfı açılır.
		2.3.2. Concrete klasörü açılır. Projede ihiyaç duyulan varlıklar OOP ve SOLID prensiplerine ayrıca ilişkisel veritabanına göre yaratılır.
		Not: Bu projede Core.Identity sınıfında yararlanacağımızdan concrete klasörü içerisinde ihtiyaçalra yönelik haraket etmeliyiz. Örneğin Core.Identity sınıfı bize bir çok hazır tablo ve yapı sunmaktadır. Bu yüzden alışık olduğıunuz gibi BaseEntity.cs sınıfından Id'yi bütün tablolara basamayacağız. Çünkü Identity sınıfının string tipinde kendi Id si bulunmaktadır. 
	2.4. Extention klasörü açılır.
3. Solution altına Class Library (.Net Core) proje tipinde YMS5177_CMS.Map adında bir proje eklenir.
	3.1. Aşağıdaki paketleri yükleyiniz
		3.1.1. Microsoft.EntityFrameworkCore
	3.2. YMS5177_CMS.Entity prjesini ilgilli katmanın referance'lerine ekleyin
	3.3. Mapping klasörü açlılır.
		3.3.1. Abstract klasörü açılır. Abstract olarak işaratlenmiş BaseMap.cs sınıf yaratılır. Varlıkların ortak özellikleri burada map edilir. Ayrıca ilgili sınıf diğer concrete map sınıflarınında atası olarak kullanılır.
		3.3.2. Concrete kalsörü açılır. Projede kullanılan varlıklar burada mapping işlemleri yapılır.
4. Solution altına Class Library (.Net Core) proje tipinde YMS5177_CMS.Data adında bir proje eklenir.
	4.1. Aşağıdaki paketleri yükleyin
		4.1.1.Microsoft.AspNetCore.Identity.EntityFrameworkCore 
		4.1.2.Microsoft.EntityFrameworkCore.SqlServer
		4.1.3. Microsoft.EntityFrameworkCore.Tools
	4.2. Aşağıdaki projeleri ilgil katmanın referancelerine ekleyin
		4.2.1. YMS5177_CMS.Entity layer
		4.2.2. YMS5177_CMS.Map layer
	4.3. SeedData klasörü eklenir. SeedPages.cs sınıfı içerisi veritabanına gönderilecek test veri seti oluşturulur.
	4.4. Context klasörü oluşturulur. ApplicationDbContext.cs sınıf yaratılır. İlgili sınıf .. kalıtılır. Varlıklar DbSet edilir. Map işlemleri implemet edilir. SeedData eklenir.
	4.5. Repositories klasörü açılır.
		4.5.1. Interfaces kalsrörü açılır.
			4.5.1.1. Base kalsörü açılır.
			4.5.1.2. EntityTypeRepositories açılır.
		4.5.2. Concrete klasörü açılır.
			4.5.2.1. Base kalsörü açılır.
			4.5.2.2. EntityTypeRepositories açılır.
			
		-----AppUser Kullanım sebebi;Appauaser bizlere kullanıcı ekler.Örneğin kuracağımız siteyi gezecek ve kullanacak admin guest gibi.
		Category Kullanmamızın sebebi;Category bizim ürün olarak eklediğimiz içeriği kapsayan bir kısımdır.Örneğin bir haber sitesi için kategoriler;spor,magazin,teknoloji
		Product Kullanım sebebi;Category ile alakalı bağı olacak varlıklar çoka çok veya teke çok ilişkileri olabilir.
		Page;Sayfamızı oluştururken bize gerekli olan varlıklardır.
		Entity;Projemizde kullanacağımız önden düşündüğümüz tüm varlıklardır.Entity katmanında varlıklarımızı tanıtırız.Tiplerini,özelliklerini,kalıtımlarını tanıtıyoruz
		Data;Daha sonra dataya geçip migration hazırlıklarını yapıyoruz.Burdaki entity repositorylerini interfaceten çekiyoruz.
		Map;Map katmanına geçip tablolarımızı(kim neyle ilişkili) programımıza tanıtıyoruz.
