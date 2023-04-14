namespace loginuser.Data;

public static class Store
{
    public static List<User> Users = new List<User>{
        new User{Id=1,Username="user1",FirstName="Fatih",LastName="Baytar"},
        new User{Id=2,Username="user2",FirstName="Fatih",LastName="Baytar"},
        new User{Id=3,Username="user3",FirstName="Fatih",LastName="Baytar"},
        new User{Id=4,Username="user4",FirstName="Fatih",LastName="Baytar"},
        new User{Id=5,Username="user5",FirstName="Fatih",LastName="Baytar"},
        new User{Id=6,Username="user6",FirstName="Fatih",LastName="Baytar"},
        new User{Id=7,Username="user7",FirstName="Fatih",LastName="Baytar"},
        new User{Id=8,Username="user8",FirstName="Fatih",LastName="Baytar"},
    };
    public static List<Product> Products = new List<Product>{
        new Product{Id=1,Name="Product1",Description="Description1",Price=10,Image="1.jpg"},
        new Product{Id=2,Name="Product2",Description="Description2",Price=20,Image="2.jpg"},
        new Product{Id=3,Name="Product3",Description="Description3",Price=30,Image="3.jpg"},
        new Product{Id=4,Name="Product4",Description="Description4",Price=40,Image="4.jpg"},
        new Product{Id=5,Name="Product5",Description="Description5",Price=50,Image="5.jpg"}
    };
    public static List<Basket> Baskets = new List<Basket>{
        new Basket{Id=1,UserId=1,ProductId=1,Quantity=1},
        new Basket{Id=2,UserId=1,ProductId=2,Quantity=1},
        new Basket{Id=3,UserId=1,ProductId=3,Quantity=1}
    };

}