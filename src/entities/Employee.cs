public class Employee{

    public string id {get; set;}
    public string name {get; set;}
    public string address {get; set;}
    public string email {get; set;}
    public string phone {get; set;}
    public string role {get; set;}


    public Employee(){
        
    }

    public Employee(string id, string name, string address, string email, string phone, string role){
        this.id = id;
        this.name = name;
        this.address = address;
        this.email = email;
        this.phone = phone;
        this.role = role;
    }
    


    public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Address: {address}, Email: {email}, Phone: {phone}, Role: {role}";
        }

}