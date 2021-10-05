package Model.Items;

import Model.FinanceItem;

public class Price implements FinanceItem {
    private Integer price;

    public Price(Integer price) {
        this.price = price;
    }

    public Integer getPrice() {
        return price;
    }

    public void setPrice(Integer price) {
        this.price = price;
    }
}
