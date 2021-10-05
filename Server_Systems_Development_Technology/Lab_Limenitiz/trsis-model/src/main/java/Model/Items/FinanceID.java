package Model.Items;

import Model.FinanceItem;

public class FinanceID implements FinanceItem {
    private int id;

    public FinanceID(int id) {
        this.id = id;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
}
