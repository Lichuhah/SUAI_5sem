import lab.example.lab1.ErrorServlet
import javax.swing.text.StyledEditorKit

object Storage {
    val roomList = mutableListOf<Room>()

    /** колличество комнат **/
    fun size() = roomList.size

    /** добавление комнаты на склад
     * true - успешное добавлени**/
    fun addRoom(name: String, id: Int) : Boolean {
        if (name.isNotEmpty() && id >= 0) {
            for (r in roomList)
                if (r.name == name || r.id == id) {
                    erroreStorage.error("Error room with such data already exists")
                    return false
                }
            roomList.add(Room(name, id))
            return true
        } else {
            erroreStorage.error("Error directional data about the room")
            return false
        }
    }

    /** удаление комнаты **/
    fun deleteRoom(id: Int): Boolean {
        for (i in 0 until roomList.size) {
            if ( roomList[i].id == id ) {
                roomList.removeAt(i)
                return true
            }
        }
        erroreStorage.error("Error this room not found")
        return false
    }

}