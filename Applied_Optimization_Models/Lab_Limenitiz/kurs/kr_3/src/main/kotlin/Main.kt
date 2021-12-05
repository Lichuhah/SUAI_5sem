import Data.ExcelReader
import Data.UpdateExcel
import androidx.compose.ui.window.Window
import androidx.compose.ui.window.application

fun main() = application {

    //Загруска при запуске
    ExcelReader.read()

    Window(onCloseRequest = ::exitApplication) {
        App()
    }
}
