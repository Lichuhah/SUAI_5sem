import Data.ExcelReader
import Data.UpdateExcel
import androidx.compose.foundation.background
import androidx.compose.foundation.border
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.text.BasicTextField
import androidx.compose.material.Button
import androidx.compose.material.ButtonDefaults
import androidx.compose.material.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.unit.dp
import repository.ExpensesRepository
import repository.IncomeRepository
import repository.ProgrammerRepository

@Composable
fun App() {
    Column {
        tableView()
        downButton()
    }
}

@Composable
fun downButton() {
    Row {
        Button(
            onClick = { ExcelReader.read()},
            content = { Text("Загрузить")},
            modifier = Modifier.padding(10.dp),
            colors = ButtonDefaults.buttonColors(backgroundColor = Color.Gray)
        )
        Button(
            onClick = { UpdateExcel.changeCalls() },
            content = { Text("Сохранить")},
            modifier = Modifier.padding(10.dp),
            colors = ButtonDefaults.buttonColors(backgroundColor = Color.Gray)
        )
    }
}

fun checkToDouble(string: String) =
    if ("""[^\d\.]""".toRegex().containsMatchIn(string)) null
    else string

fun checkToInt(string: String) =
    if ("""[\D]""".toRegex().containsMatchIn(string) ) null
    else string

val column1Weight = .1f
val column2Weight = .3f
val column3Weight = .3f
val column4Weight = .3f

@Composable
fun tableView() {
    println("tableView")

    var p1 by remember { mutableStateOf(ProgrammerRepository.data[0]) }
    var p2 by remember { mutableStateOf(ProgrammerRepository.data[1]) }
    var p3 by remember { mutableStateOf(ProgrammerRepository.data[2]) }
    var p4 by remember { mutableStateOf(ProgrammerRepository.data[3]) }
    var p5 by remember { mutableStateOf(ProgrammerRepository.data[4]) }
    var p6 by remember { mutableStateOf(ProgrammerRepository.data[5]) }

    var i1 by remember { mutableStateOf(IncomeRepository.data[0]) }
    var i3 by remember { mutableStateOf(IncomeRepository.data[2]) }
    var i4 by remember { mutableStateOf(IncomeRepository.data[3]) }
    var i2 by remember { mutableStateOf(IncomeRepository.data[1]) }
    var i5 by remember { mutableStateOf(IncomeRepository.data[4]) }
    var i6 by remember { mutableStateOf(IncomeRepository.data[5]) }

    var e1 by remember { mutableStateOf(ExpensesRepository.data[0]) }
    var e3 by remember { mutableStateOf(ExpensesRepository.data[2]) }
    var e4 by remember { mutableStateOf(ExpensesRepository.data[3]) }
    var e2 by remember { mutableStateOf(ExpensesRepository.data[1]) }
    var e5 by remember { mutableStateOf(ExpensesRepository.data[4]) }
    var e6 by remember { mutableStateOf(ExpensesRepository.data[5]) }

    LazyColumn(Modifier.fillMaxSize(0.9f).padding(16.dp)) {
        item {
            Row(Modifier.background(Color.Gray)) {
                TableCell(text = "№", weight = column1Weight)
                TableCell(text = "Программисты", weight = column2Weight)
                TableCell(text = "Траты на разработку", weight = column3Weight)
                TableCell(text = "Ожидаемый доход", weight = column4Weight)
            }
        }

        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "1", weight = column1Weight)
                BasicTextField(
                    value = p1.toString(),
                    onValueChange = {
                        checkToInt(it)?.let {
                            p1 = it.toInt()
                            ProgrammerRepository.data[0] = it.toInt()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = e1.toString(),
                    onValueChange = {
                        checkToDouble(it)?.let {
                            e1 = it.toDouble()
                            ExpensesRepository.data[0] = it.toDouble()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = i1.toString(),
                    onValueChange = {
                        checkToDouble(it)?.let {
                            i1 = it.toDouble()
                            IncomeRepository.data[0] = it.toDouble()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column4Weight)
                        .padding(8.dp)
                )
            }
        }


        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "2", weight = column1Weight)
                BasicTextField(
                    value = p2.toString(),
                    onValueChange = {
                        checkToInt(it)?.let {
                            p2 = it.toInt()
                            ProgrammerRepository.data[1] = it.toInt()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = e2.toString(),
                    onValueChange = {
                        checkToDouble(it)?.let {
                            e2 = it.toDouble()
                            ExpensesRepository.data[1] = it.toDouble()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = i2.toString(),
                    onValueChange = {
                        checkToDouble(it)?.let {
                            i2 = it.toDouble()
                            IncomeRepository.data[1] = it.toDouble()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column4Weight)
                        .padding(8.dp)
                )
            }
        }
        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "3", weight = column1Weight)
                BasicTextField(
                    value = p3.toString(),
                    onValueChange = {
                        checkToInt(it)?.let {
                            p3 = it.toInt()
                            ProgrammerRepository.data[2] = it.toInt()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = e3.toString(),
                    onValueChange = {
                        checkToDouble(it)?.let {
                            e3 = it.toDouble()
                            ExpensesRepository.data[2] = it.toDouble()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = i3.toString(),
                    onValueChange = {
                        checkToDouble(it)?.let {
                            i3 = it.toDouble()
                            IncomeRepository.data[2] = it.toDouble()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column4Weight)
                        .padding(8.dp)
                )
            }
        }

        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "4", weight = column1Weight)
                BasicTextField(
                    value = p4.toString(),
                    onValueChange = {
                        checkToInt(it)?.let {
                            p4 = it.toInt()
                            ProgrammerRepository.data[3] = it.toInt()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = e4.toString(),
                    onValueChange = {
                        checkToDouble(it)?.let {
                            e4 = it.toDouble()
                            ExpensesRepository.data[3] = it.toDouble()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = i4.toString(),
                    onValueChange = {
                        checkToDouble(it)?.let {
                            i4 = it.toDouble()
                            IncomeRepository.data[3] = it.toDouble()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column4Weight)
                        .padding(8.dp)
                )
            }
        }

        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "5", weight = column1Weight)
                BasicTextField(
                    value = p5.toString(),
                    onValueChange = {
                        checkToInt(it)?.let {
                            p5 = it.toInt()
                            ProgrammerRepository.data[4] = it.toInt()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = e5.toString(),
                    onValueChange = {
                        checkToDouble(it)?.let {
                            e5 = it.toDouble()
                            ExpensesRepository.data[4] = it.toDouble()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = i5.toString(),
                    onValueChange = {
                        checkToDouble(it)?.let {
                            i5 = it.toDouble()
                            IncomeRepository.data[4] = it.toDouble()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column4Weight)
                        .padding(8.dp)
                )
            }
        }

        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "6", weight = column1Weight)
                BasicTextField(
                    value = p6.toString(),
                    onValueChange = {
                        checkToInt(it)?.let {
                            p6 = it.toInt()
                            ProgrammerRepository.data[5] = it.toInt()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = e6.toString(),
                    onValueChange = {
                        checkToDouble(it)?.let {
                            e6 = it.toDouble()
                            ExpensesRepository.data[5] = it.toDouble()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = i6.toString(),
                    onValueChange = {
                        checkToDouble(it)?.let {
                            i6 = it.toDouble()
                            IncomeRepository.data[5] = it.toDouble()
                        }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column4Weight)
                        .padding(8.dp)
                )
            }
        }

    }
}

@Composable
fun RowScope.TableCell(
    text: String,
    weight: Float
) {
    Text(
        text = text,
        Modifier
            .border(1.dp, Color.Black)
            .weight(weight)
            .padding(8.dp)
    )
}
