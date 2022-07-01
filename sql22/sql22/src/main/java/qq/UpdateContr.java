package qq;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.scene.control.*;

import java.sql.Date;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.time.LocalDate;

import static qq.ToClass.*;
import static qq.ToClass.getGosnumber;

public class UpdateContr implements EventHandler<ActionEvent> {
    @FXML
    private Label label;
    private ObservableList<Database> clientusers = FXCollections.observableArrayList();

    @FXML
    private TextField licensevehicle;
    @FXML
    private TextField id_client;
    @FXML
    private DatePicker checkintime;
    @FXML
    private DatePicker checkouttime;
    @FXML
    private TextField numberphone;
    @FXML
    private TextField lastname;
    @FXML
    private TextField price;
    @FXML
    private TextField firstname;

    @FXML
    private TextField midname;

    @FXML
    private TextField carname;

    @FXML
    private Button button;

    public Connect bd;
    @FXML
    public void initialize() throws SQLException {
        bd = new Connect();
        ResultSet rsfirstname = bd.Select("select \"Firstname\", \"Midname\" from \"Clients\" " +
                "where \"Gosnumber\" = '"+getGosnumber()+"'");
        if (rsfirstname.next()){
            firstname.setText(rsfirstname.getString(1));
            midname.setText(rsfirstname.getString(2));
        }
        button.setOnAction(this);
        id_client.setText(GetSelecter().toString());
        carname.setText(getAutotitle());
        licensevehicle.setText(getGosnumber());
        checkintime.setValue(getInDate());
        checkouttime.setValue(getOutDate());
        numberphone.setText(getN_phone().toString());
        lastname.setText(getClientname());
        price.setText(getBigsumm().toString());
    }
    @Override
    public void handle(ActionEvent actionEvent) {
        if (actionEvent.getSource() == button) {
            clientusers.clear();
            String type = (String) carname.getText();
            String lastnameText = (String) lastname.getText();
            String licen = licensevehicle.getText();
            String nphone = numberphone.getText();
            String priceee = price.getText();
            String firstn = firstname.getText();
            String midn = midname.getText();
            LocalDate checkin = checkintime.getValue();
            LocalDate checkout = checkouttime.getValue();


            try {
                int id_auto = 0;
                ResultSet au = bd.Select("select \"Id\" from \"Autos\" where \"Autoname\"='"+type+"'");
                if (au.next()){
                    id_auto = au.getInt(1);
                }

                ResultSet rs = bd.Select(("select \"Autoname\" , \"Gosnumber\", \"Indate\", " +
                        "\"Outdate\", \"Numberphone\", \"Lastname\", \"Summ\" " +
                        "from \"Vouchers\" as V " +
                        "inner join \"Contracts\" C on V.\"Id\" = C.\"VouchersId\"" +
                        "inner join \"Clients\" cl on C.\"ClientsId\" = cl.\"Id\""+
                        "inner join \"Autos\" A on cl.\"AutosId\" = A.\"Id\" " +
                        "group by \"Autoname\", \"Gosnumber\", \"Lastname\", \"Indate\", \"Outdate\"," +
                        "\"Numberphone\", \"Lastname\", \"Summ\""));
                while (rs.next()) {
                    clientusers.add(new Database("go",
                            rs.getString("carname"),
                            rs.getString("licensevehicle"),
                            rs.getDate("checkintime"),
                            rs.getDate("checkouttime"),
                            rs.getString("numberphone"),
                            rs.getString("lastname"),
                            rs.getInt("price")
                    ));
                }
                int id = clientusers.size() + 1;
                int id2 = Integer.parseInt(id_client.getText());
                if (lastnameText.isEmpty()==false){

                    bd.InsertnUpdate("update \"Clients\" " +
                            "set \"Lastname\"='"+lastnameText + "', \"Firstname\"='"+firstn+"',"+
                            "\"Midname\"='"+midn+"',"+"\"Gosnumber\"='"+licen+"', \"AutosId\"="+id_auto+
                            ", \"Numberphone\"='"+nphone+"' "+
                            "where \"Id\"="+id2);
                    // команда update изменить чо как с id быьт

                    bd.InsertnUpdate("update \"Vouchers\" set \"Indate\"='"+checkintime.getValue().toString()+"',"+
                            "\"Outdate\"='"+checkouttime.getValue().toString()+"', \"Summ\" ="+priceee +
                            " where \"Id\"="+id2);
                    label.setText("Обновлено");
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }
    }
}
