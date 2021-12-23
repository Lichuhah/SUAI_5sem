package com.example.lab4;

import java.util.Date;

public class Doctor_Patient {
    public Integer id;
    public Integer iddoc;
    public Integer idpat;
    public Doctor doc;
    public Patient pat;
    public String info;

    public Integer getIddoc() {
        return iddoc;
    }

    public void setIddoc(Integer iddoc) {
        this.iddoc = iddoc;
    }

    public Integer getIdpat() {
        return idpat;
    }

    public void setIdpat(Integer idpat) {
        this.idpat = idpat;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public Doctor getDoc() {
        return doc;
    }

    public Patient getPat() {
        return pat;
    }

    public String getInfo() {
        return info;
    }

    public void setDoc(Doctor doc) {
        this.doc = doc;
    }

    public void setPat(Patient pat) {
        this.pat = pat;
    }

    public void setInfo(String info) {
        this.info = info;
    }
}
