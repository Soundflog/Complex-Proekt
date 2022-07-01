package qq;


import java.sql.Date;
import java.time.LocalDateTime;
import java.time.ZonedDateTime;

public class Database {
    public String Status;
    public String carname;
    public String licensevehicle;
    public Date checkintime;
    public Date checkouttime;
    public String numberphone;
    public String lastname;
    public int price;
//    public int id_role;
//    public String namerole;

    public Database(String Status, String carname, String licensevehicle,
                    Date checkintime, Date checkouttime, String numberphone,
                    String lastname, int price) {
        this.Status=Status;
        this.carname=carname;
        this.licensevehicle=licensevehicle;
        this.checkintime=checkintime;
        this.checkouttime=checkouttime;
        this.numberphone=numberphone;
        this.lastname=lastname;
        this.price=price;
    }

    public Database() {
    }

    public String getStatus() {
        return Status;
    }

    public void setStatus(String status) {
        Status = status;
    }

    public String getCarname() {
        return carname;
    }

    public void setCarname(String carname) {
        this.carname = carname;
    }

    public String getLicensevehicle() {
        return licensevehicle;
    }

    public void setLicensevehicle(String licensevehicle) {
        this.licensevehicle = licensevehicle;
    }

    public Date getCheckintime() {
        return checkintime;
    }

    public void setCheckintime(Date checkintime) {
        this.checkintime = checkintime;
    }

    public Date getCheckouttime() {
        return checkouttime;
    }

    public void setCheckouttime(Date checkouttime) {
        this.checkouttime = checkouttime;
    }

    public String getNumberphone() {
        return numberphone;
    }

    public void setNumberphone(String numberphone) {
        this.numberphone = numberphone;
    }

    public String getLastname() {
        return lastname;
    }

    public void setLastname(String lastname) {
        this.lastname = lastname;
    }

    public int getPrice() {
        return price;
    }

    public void setPrice(int price) {
        this.price = price;
    }
}
