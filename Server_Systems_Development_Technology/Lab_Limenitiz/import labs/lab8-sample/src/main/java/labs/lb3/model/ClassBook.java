package labs.lb3.model;

public class ClassBook {

    String nameCompany;
    int kolActives;
    double priceActive;
    int id = 0;

    public ClassBook(String input_name, int input_kol_actives, double input_price_active) {
        nameCompany = input_name;
        kolActives = input_kol_actives;
        priceActive = input_price_active;
    }

    public void setNameCompany(String nameCompany) {
        this.nameCompany = nameCompany;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setKolActives(int kolActives) {
        this.kolActives = kolActives;
    }

    public void setPriceActive(double priceActive) {
        this.priceActive = priceActive;
    }

    public double getPriceActive() {
        return priceActive;
    }

    public int getId() {
        return id;
    }

    public int getKolActives() {
        return kolActives;
    }

    public String getNameCompany() {
        return nameCompany;
    }
}

