 public class Customer {
 
     private string _name;
     private Address _address;
 
     public Customer(string name, Address address)
     {
         this._name = name;
         this._address = address;
     }

     public string customerInfo()
     {
        return $"{_name}\n{_address.address()}";
     }

     public bool livesInUS()
     {
        if (_address.isUS())
        {
            return true;
        }
        else
        {
            return false;
        }
     }
 }