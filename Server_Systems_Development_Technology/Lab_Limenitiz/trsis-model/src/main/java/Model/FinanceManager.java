package Model;

import Model.Items.*;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;

public class FinanceManager {

    // <Singleton code>
    private static volatile FinanceManager instance;
    private FinanceManager(){}

    public static FinanceManager getInstance() {
        FinanceManager result = instance;
        if (result != null) {
            return result;
        }
        synchronized(FinanceManager.class) {
            if (instance == null) {
                instance = new FinanceManager();
            }
            return instance;
        }
    }
    // </Singleton code>

    private Integer totalCost = 0;
    private final List<FinanceID> id = new LinkedList<>();
    private final List<Name> names = new ArrayList<>();
    private final List<Price> prices = new ArrayList<>();
    private final List<Category> categories = new ArrayList<>();
    private final List<Customer> customers = new ArrayList<>();
    private final List<List<? extends FinanceItem>> costs = Arrays.asList( id, names, prices, categories, customers );

    public static String getColumnName(ColumnName name){
        List<String> columnNames = Arrays.asList(
                "ID",
                "Name",
                "Price",
                "Category",
                "Customer"
        );

        return columnNames.get(getColumnIndex(name));
    }

    public static int getColumnIndex(ColumnName name){
        List<ColumnName> names = Arrays.asList(
                ColumnName.ID,
                ColumnName.NAME,
                ColumnName.PRICE,
                ColumnName.CATEGORY,
                ColumnName.CUSTOMER
        );

        return names.indexOf(name);
    }

    public void addCost(String name, Integer price, Category category, Customer customer) throws Exception {
        if(price < 0){
            throw new Exception("Price must be positive");
        }
        totalCost += price;

        id.add(new FinanceID(id.get(id.size()-1).getId()+1)); // auto increment index
        names.add(new Name(name));
        prices.add(new Price(price));
        categories.add(category);
        customers.add(customer);
    }

    public void rmCost(int remove_id) {
        int index = id.indexOf(new FinanceID(remove_id));
        if(index < 0) { return; }
        totalCost -= prices.get(index).getPrice();
        names.remove(index);
        prices.remove(index);
        categories.remove(index);
        customers.remove(index);
    }

    public List<List<? extends FinanceItem>> getCosts() {
        return costs;
    }

    public Integer getTotalCost() {
        return totalCost;
    }
}
