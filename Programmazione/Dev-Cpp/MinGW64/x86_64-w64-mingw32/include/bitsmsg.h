/**
 * This file has no copyright assigned and is placed in the Public Domain.
 * This file is part of the mingw-w64 runtime package.
 * No warranty is given; refer to the file DISCLAIMER.PD within this package.
 */
#ifndef _BGCPYMSG_
#define _BGCPYMSG_

#ifndef BG_E_NOT_FOUND
#define BG_E_NOT_FOUND __MSABI_LONG(0x80200001)
#define BG_E_INVALID_STATE __MSABI_LONG(0x80200002)
#define BG_E_EMPTY __MSABI_LONG(0x80200003)
#define BG_E_FILE_NOT_AVAILABLE __MSABI_LONG(0x80200004)
#define BG_E_PROTOCOL_NOT_AVAILABLE __MSABI_LONG(0x80200005)
#define BG_S_ERROR_CONTEXT_NONE __MSABI_LONG(0x00200006)
#define BG_E_ERROR_CONTEXT_UNKNOWN __MSABI_LONG(0x80200007)
#define BG_E_ERROR_CONTEXT_GENERAL_QUEUE_MANAGER __MSABI_LONG(0x80200008)
#define BG_E_ERROR_CONTEXT_LOCAL_FILE __MSABI_LONG(0x80200009)
#define BG_E_ERROR_CONTEXT_REMOTE_FILE __MSABI_LONG(0x8020000A)
#define BG_E_ERROR_CONTEXT_GENERAL_TRANSPORT __MSABI_LONG(0x8020000B)
#define BG_E_ERROR_CONTEXT_QUEUE_MANAGER_NOTIFICATION __MSABI_LONG(0x8020000C)
#define BG_E_DESTINATION_LOCKED __MSABI_LONG(0x8020000D)
#define BG_E_VOLUME_CHANGED __MSABI_LONG(0x8020000E)
#define BG_E_ERROR_INFORMATION_UNAVAILABLE __MSABI_LONG(0x8020000F)
#define BG_E_NETWORK_DISCONNECTED __MSABI_LONG(0x80200010)
#define BG_E_MISSING_FILE_SIZE __MSABI_LONG(0x80200011)
#define BG_E_INSUFFICIENT_HTTP_SUPPORT __MSABI_LONG(0x80200012)
#define BG_E_INSUFFICIENT_RANGE_SUPPORT __MSABI_LONG(0x80200013)
#define BG_E_REMOTE_NOT_SUPPORTED __MSABI_LONG(0x80200014)
#define BG_E_NEW_OWNER_DIFF_MAPPING __MSABI_LONG(0x80200015)
#define BG_E_NEW_OWNER_NO_FILE_ACCESS __MSABI_LONG(0x80200016)
#define BG_S_PARTIAL_COMPLETE __MSABI_LONG(0x00200017)
#define BG_E_PROXY_LIST_TOO_LARGE __MSABI_LONG(0x80200018)
#define BG_E_PROXY_BYPASS_LIST_TOO_LARGE __MSABI_LONG(0x80200019)
#define BG_S_UNABLE_TO_DELETE_FILES __MSABI_LONG(0x0020001A)
#define BG_E_INVALID_SERVER_RESPONSE __MSABI_LONG(0x8020001B)
#define BG_E_TOO_MANY_FILES __MSABI_LONG(0x8020001C)
#define BG_E_LOCAL_FILE_CHANGED __MSABI_LONG(0x8020001D)
#define BG_E_ERROR_CONTEXT_REMOTE_APPLICATION __MSABI_LONG(0x8020001E)
#define BG_E_SESSION_NOT_FOUND __MSABI_LONG(0x8020001F)
#define BG_E_TOO_LARGE __MSABI_LONG(0x80200020)
#define BG_E_STRING_TOO_LONG __MSABI_LONG(0x80200021)
#define BG_E_CLIENT_SERVER_PROTOCOL_MISMATCH __MSABI_LONG(0x80200022)
#define BG_E_SERVER_EXECUTE_ENABLE __MSABI_LONG(0x80200023)
#define BG_E_NO_PROGRESS __MSABI_LONG(0x80200024)
#define BG_E_USERNAME_TOO_LARGE __MSABI_LONG(0x80200025)
#define BG_E_PASSWORD_TOO_LARGE __MSABI_LONG(0x80200026)
#define BG_E_INVALID_AUTH_TARGET __MSABI_LONG(0x80200027)
#define BG_E_INVALID_AUTH_SCHEME __MSABI_LONG(0x80200028)
#define BG_E_FILE_NOT_FOUND __MSABI_LONG(0x80200029)
#define BG_S_PROXY_CHANGED __MSABI_LONG(0x0020002A)
#define BG_E_INVALID_RANGE __MSABI_LONG(0x8020002B)
#define BG_E_OVERLAPPING_RANGES __MSABI_LONG(0x8020002C)
#define BG_E_CONNECT_FAILURE __MSABI_LONG(0x8020002D)
#define BG_E_CONNECTION_CLOSED __MSABI_LONG(0x8020002E)
#define BG_E_KEEP_ALIVE_FAILURE __MSABI_LONG(0x8020002F)
#define BG_E_MESSAGE_LENGTH_LIMIT_EXCEEDED __MSABI_LONG(0x80200030)
#define BG_E_NAME_RESOLUTION_FAILURE __MSABI_LONG(0x80200031)
#define BG_E_PENDING __MSABI_LONG(0x80200032)
#define BG_E_PIPELINE_FAILURE __MSABI_LONG(0x80200033)
#define BG_E_PROTOCOL_ERROR __MSABI_LONG(0x80200034)
#define BG_E_PROXY_NAME_RESOLUTION_FAILURE __MSABI_LONG(0x80200035)
#define BG_E_RECEIVE_FAILURE __MSABI_LONG(0x80200036)
#define BG_E_REQUEST_CANCELED __MSABI_LONG(0x80200037)
#define BG_E_SECURE_CHANNEL_FAILURE __MSABI_LONG(0x80200038)
#define BG_E_SEND_FAILURE __MSABI_LONG(0x80200039)
#define BG_E_SERVER_PROTOCOL_VIOLATION __MSABI_LONG(0x8020003A)
#define BG_E_TIMEOUT __MSABI_LONG(0x8020003B)
#define BG_E_TRUST_FAILURE __MSABI_LONG(0x8020003C)
#define BG_E_UNKNOWN_ERROR __MSABI_LONG(0x8020003D)
#define BG_E_BLOCKED_BY_POLICY __MSABI_LONG(0x8020003E)
#define BG_E_INVALID_PROXY_INFO __MSABI_LONG(0x8020003F)
#define BG_E_INVALID_CREDENTIALS __MSABI_LONG(0x80200040)
#define BG_E_HTTP_ERROR_100 __MSABI_LONG(0x80190064)
#define BG_E_HTTP_ERROR_101 __MSABI_LONG(0x80190065)
#define BG_E_HTTP_ERROR_200 __MSABI_LONG(0x801900C8)
#define BG_E_HTTP_ERROR_201 __MSABI_LONG(0x801900C9)
#define BG_E_HTTP_ERROR_202 __MSABI_LONG(0x801900CA)
#define BG_E_HTTP_ERROR_203 __MSABI_LONG(0x801900CB)
#define BG_E_HTTP_ERROR_204 __MSABI_LONG(0x801900CC)
#define BG_E_HTTP_ERROR_205 __MSABI_LONG(0x801900CD)
#define BG_E_HTTP_ERROR_206 __MSABI_LONG(0x801900CE)
#define BG_E_HTTP_ERROR_300 __MSABI_LONG(0x8019012C)
#define BG_E_HTTP_ERROR_301 __MSABI_LONG(0x8019012D)
#define BG_E_HTTP_ERROR_302 __MSABI_LONG(0x8019012E)
#define BG_E_HTTP_ERROR_303 __MSABI_LONG(0x8019012F)
#define BG_E_HTTP_ERROR_304 __MSABI_LONG(0x80190130)
#define BG_E_HTTP_ERROR_305 __MSABI_LONG(0x80190131)
#define BG_E_HTTP_ERROR_307 __MSABI_LONG(0x80190133)
#define BG_E_HTTP_ERROR_400 __MSABI_LONG(0x80190190)
#define BG_E_HTTP_ERROR_401 __MSABI_LONG(0x80190191)
#define BG_E_HTTP_ERROR_402 __MSABI_LONG(0x80190192)
#define BG_E_HTTP_ERROR_403 __MSABI_LONG(0x80190193)
#define BG_E_HTTP_ERROR_404 __MSABI_LONG(0x80190194)
#define BG_E_HTTP_ERROR_405 __MSABI_LONG(0x80190195)
#define BG_E_HTTP_ERROR_406 __MSABI_LONG(0x80190196)
#define BG_E_HTTP_ERROR_407 __MSABI_LONG(0x80190197)
#define BG_E_HTTP_ERROR_408 __MSABI_LONG(0x80190198)
#define BG_E_HTTP_ERROR_409 __MSABI_LONG(0x80190199)
#define BG_E_HTTP_ERROR_410 __MSABI_LONG(0x8019019A)
#define BG_E_HTTP_ERROR_411 __MSABI_LONG(0x8019019B)
#define BG_E_HTTP_ERROR_412 __MSABI_LONG(0x8019019C)
#define BG_E_HTTP_ERROR_413 __MSABI_LONG(0x8019019D)
#define BG_E_HTTP_ERROR_414 __MSABI_LONG(0x8019019E)
#define BG_E_HTTP_ERROR_415 __MSABI_LONG(0x8019019F)
#define BG_E_HTTP_ERROR_416 __MSABI_LONG(0x801901A0)
#define BG_E_HTTP_ERROR_417 __MSABI_LONG(0x801901A1)
#define BG_E_HTTP_ERROR_449 __MSABI_LONG(0x801901C1)
#define BG_E_HTTP_ERROR_500 __MSABI_LONG(0x801901F4)
#define BG_E_HTTP_ERROR_501 __MSABI_LONG(0x801901F5)
#define BG_E_HTTP_ERROR_502 __MSABI_LONG(0x801901F6)
#define BG_E_HTTP_ERROR_503 __MSABI_LONG(0x801901F7)
#define BG_E_HTTP_ERROR_504 __MSABI_LONG(0x801901F8)
#define BG_E_HTTP_ERROR_505 __MSABI_LONG(0x801901F9)
#define BITS_MC_JOB_CANCELLED __MSABI_LONG(0x80194000)
#define BITS_MC_FILE_DELETION_FAILED __MSABI_LONG(0x80194001)
#define BITS_MC_FILE_DELETION_FAILED_MORE __MSABI_LONG(0x80194002)
#define BITS_MC_JOB_PROPERTY_CHANGE __MSABI_LONG(0x80194003)
#define BITS_MC_JOB_TAKE_OWNERSHIP __MSABI_LONG(0x80194004)
#define BITS_MC_JOB_SCAVENGED __MSABI_LONG(0x80194005)
#define BITS_MC_JOB_NOTIFICATION_FAILURE __MSABI_LONG(0x80194006)
#define BITS_MC_STATE_FILE_CORRUPT __MSABI_LONG(0x80194007)
#define BITS_MC_FAILED_TO_START __MSABI_LONG(0x80194008)
#endif
#endif
