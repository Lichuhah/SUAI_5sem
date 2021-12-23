package com.example.demo.data

fun objFactory(name: String, count: Int) =
    if ( name.isNotEmpty() && count >= 0 )
        Obj(name, count)
    else
        null