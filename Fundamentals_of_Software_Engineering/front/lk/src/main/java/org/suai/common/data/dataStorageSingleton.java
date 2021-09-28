package org.suai.common.data;

import com.google.gson.GsonBuilder;
import org.suai.common.Response;
import org.suai.common.enum_.REQUEST_TYPE;
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
public class dataStorageSingleton extends dataStorage {

    // <Singleton code>
    private static volatile dataStorageSingleton instance;
    private dataStorageSingleton(){}

    public static dataStorageSingleton getInstance(){
        dataStorageSingleton result = instance;
        if (result != null) {
            return result;
        }
        synchronized(dataStorageSingleton.class) {
            if (instance == null) {
                instance = new dataStorageSingleton();
            }
            return instance;
        }
    }
    // </Singleton code>


    public studentModel getStudentModel(Integer id){
        for( var student : getStudents()){
            if(student.getId() == id){
                return student;
            }
        }

        String response = Net.INSTANCE.request(REQUEST_TYPE.GET, "Student/Get", id.toString());
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
