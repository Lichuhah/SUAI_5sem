package org.suai.common.utils

import okhttp3.ResponseBody

fun ResponseBody.toString() = this.string();