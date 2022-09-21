namespace MTechSystems.Test.Stages
{
	public class Stage2
	{
		static void Main(string[] args)
		{
			/*
			 1) 
			  Create new class 'TruckWeight' with the following properties
				> TruckID (string)
				> Capacity (decimal)	   
				> Active (bool)	
			  2) 
				Create a list/collection of truck weights
				| TruckID	     |	Capacity	|	Active	|
				----------------------------------------------
				| Fuel Truck      |   10000      |   True    |
				| Tanker          |   22000		|   True	|
				| Trailer		 |   50000		|   True	|
				| Car Transporter |   30000		|   False   |
				3)
				 Find the active trucks with capacity less than 50000
			*/

			var ListTrucks = new List<TruckWeight>();

			ListTrucks.Add(new TruckWeight { TruckID = "Fuel Truck", Capacity = 10000, Active = true});
			ListTrucks.Add(new TruckWeight { TruckID = "Tanker", Capacity = 22000, Active = true });
			ListTrucks.Add(new TruckWeight { TruckID = "Trailer", Capacity = 50000, Active = true });
			ListTrucks.Add(new TruckWeight { TruckID = "Car Transporter", Capacity = 30000, Active = false });

			foreach(var res in ListTrucks)
                if(res.Capacity < 50000 && res.Active == true)
                    Console.WriteLine(res.TruckID);
		}
	}

	public class TruckWeight
    {
		public string TruckID;
		public decimal Capacity;
		public bool Active;
    }
}