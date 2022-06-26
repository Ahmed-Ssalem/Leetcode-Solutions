public class ParkingSystem {
    
    public List<int> count;

    public ParkingSystem(int big, int medium, int small) {
        count = new List<int>{
            big, 
            medium, 
            small
            };
    }
    
    public bool AddCar(int carType) {
        if (carType == 1 && count[0] > 0){
            count[0]--;
            return true;
        }
        else if (carType == 2 && count[1] > 0){
            count[1]--;
            return true;
        }
        else if (carType == 3 && count[2] > 0){
            count[2]--;
            return true;
        }

        return false;
        
        
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */