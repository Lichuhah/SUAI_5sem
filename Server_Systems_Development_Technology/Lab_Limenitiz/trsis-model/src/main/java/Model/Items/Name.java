package Model.Items;

import Model.FinanceItem;

public class Name implements FinanceItem {
    private String name;

    public Name(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
}
