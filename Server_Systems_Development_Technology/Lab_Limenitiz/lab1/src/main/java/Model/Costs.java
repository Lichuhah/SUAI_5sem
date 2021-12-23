package Model;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.LinkedList;
import java.util.List;

public class Costs {
    private static volatile Costs instance;

    private Costs(){}

    public static Costs getInstance() {
        Costs result = instance;
        if (result != null) {
            return result;
        }
        synchronized(Costs.class) {
            if (instance == null) {
                instance = new Costs();
            }
            return instance;
        }
    }

    private Integer totalCost = 0;
    private final ArrayList<String> names = new ArrayList<String>();
    private final ArrayList<Integer> prices = new ArrayList<Integer>();

    public void addItem(String name, Integer price) throws Exception {
        if(price < 0){
            throw new Exception("Price must be positive");
        }
        else if(names.contains(name)){
            return;
        }
        totalCost += price;
        names.add(name);
        prices.add(price);
    }

    public void rmItem(String name) {
        int index = names.indexOf(name);
        if(index < 0) { return; }
        totalCost -= prices.get(index);
        names.remove(index);
        prices.remove(index);
    }

    public List<String> getNames(){
        return names;
    }
    public List<Integer> getPrices(){
        return prices;
    }
}
