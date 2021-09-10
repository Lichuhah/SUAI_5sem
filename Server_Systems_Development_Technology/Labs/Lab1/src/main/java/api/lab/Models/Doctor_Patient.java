package api.lab.Models;

import java.util.Date;

public class Doctor_Patient {
    public Doctor doc;
    public Patient pat;
    public Date time;
    public String reason;

    public Doctor getDoc() {
        return doc;
    }

    public Patient getPat() {
        return pat;
    }

    public Date getTime() {
        return time;
    }

    public String getReason() {
        return reason;
    }
}
