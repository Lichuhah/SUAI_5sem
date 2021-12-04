import Data.ExcelReader
import Data.UpdateExcel
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.material.Button
import androidx.compose.material.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import screen.lineView
import screen.productView

@Composable
fun App() {
    var vLine by remember { mutableStateOf(true) }

    Column {
        Row {
            Button(
                onClick = { vLine = true },
                content = { Text("Линии") }
            )
            Button(
                onClick = { vLine = false },
                content = { Text("Продукты") }
            )
        }

        if (vLine)  { lineView() }
        else        { productView() }
        downButton()
    }
}

@Composable
fun downButton() {
    Row {
        Button(
            onClick = { ExcelReader.read()},
            content = { Text("Загрузить")}
        )
        Button(
            onClick = { UpdateExcel.changeCalls() },
            content = { Text("Сохранить")}
        )
    }
}