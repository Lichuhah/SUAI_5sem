package org.suai.common.data;

import com.google.gson.GsonBuilder;
import org.suai.common.Response;
import org.suai.common.enum_.REQUEST;
import org.suai.common.model.docModel;
import org.suai.common.model.groupModel;
import org.suai.common.model.role.deanatModel;
import org.suai.common.model.role.lecturerModel;
import org.suai.common.model.role.studentModel;
import org.suai.common.model.role.userModel;
import org.suai.common.model.taskModel;
import org.suai.common.net.Net;

/** Singleton data storage
 *
 */
public class Storage extends onlyData {

    // <Singleton code>
    private static volatile Storage instance;
    private Storage(){}

    public static Storage getInstance(){
        Storage result = instance;
        if (result != null) {
            return result;
        }
        synchronized(Storage.class) {
            if (instance == null) {
                instance = new Storage();
            }
            return instance;
        }
    }
    // </Singleton code>


    public studentModel getStudent(Integer id){
        for( var students : getStudents()){
            if(students.getId() == id){
                return students;
            }
        }

        String response = Net.INSTANCE.request(REQUEST.GET, "Student/Get", id.toString());
        //TODO: maybe refactor


        if (!response.equals("null")){
            return new GsonBuilder()
                    .create()
                    .fromJson(response, studentModel.class);
        }

        return null;
    }

//    public lecturerModel getLecturerModel(Integer id){
//
//    }
//
//    public deanatModel getDeanatModel(Integer id){
//
//    }
//
//    public groupModel getGroupModel(Integer id){
//
//    }
//
//    public taskModel getTaskModel(Integer id){
//
//    }
//
//    public docModel getDocModel(Integer id){
//
//    }
//


}