package qq;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.ButtonType;
import javafx.scene.control.TextField;
import javafx.stage.Modality;
import javafx.stage.Stage;

import java.io.IOException;
import java.security.MessageDigest;
import java.sql.ResultSet;
import java.sql.SQLException;

public class Authorization implements EventHandler<ActionEvent> {
    @FXML
    private Button vhod;
    @FXML
    private TextField login;
    @FXML
    private TextField password;
    static int id_authorization;
    public Connect bd;
    @FXML
    public void  initialize () throws SQLException {
        bd = new Connect();
        vhod.setOnAction(this);
    }
    @Override
    public void handle(ActionEvent actionEvent) {
        String loginstr = login.getText();
        String pswrd = password.getText();
        if (actionEvent.getSource() == vhod & loginstr == "admin" & loginstr == "Воробьев"){
            try{
                ResultSet rs = bd.Select("select \"Id\" from \"Authorizations\" " +
                        "where \"Login\"='"+loginstr+"' and \"Password\"='"+pswrd+"'");
                if(rs.next()){
                    id_authorization = rs.getInt(1);
                    openfxml("hello-view.fxml");
                }
                else {
                    Alert alert = new Alert(Alert.AlertType.INFORMATION);
                    alert.setTitle("Ошибка авторизации");
                    alert.setHeaderText("Неправильный логин или пароль");
                    alert.setContentText("Попробуйте еще раз");
                    alert.showAndWait();
                }

            }catch (SQLException e){
                e.printStackTrace();
            }
        }
        else {
            Alert alert = new Alert(Alert.AlertType.INFORMATION);
            alert.setTitle("Ошибка авторизации");
            alert.setHeaderText("Неправильный логин или пароль");
            alert.setContentText("Попробуйте еще раз");
            alert.showAndWait();
        }
    }
    private void openfxml(String ffxml){
        FXMLLoader loader = new FXMLLoader();
        loader.setLocation(getClass().getResource(ffxml));
        try {
            loader.load();
        } catch (IOException e) {
            e.printStackTrace();
        }
        Parent root= loader.getRoot();
        Stage stage = new Stage();
        stage.initModality(Modality.APPLICATION_MODAL);
        stage.setScene(new Scene(root));
        stage.showAndWait();
    }
}
