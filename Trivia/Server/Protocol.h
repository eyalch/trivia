#define SIGN_IN_REQUEST "200"  // [200 ##username ##pass]
#define SIGN_OUT_REQUEST "201"  // [201]
#define SIGN_IN_RESPONSE "102"  // [See following lines]
#define SIGN_IN_RESPONSE_SUCCESS "1020"  // [1020]
#define SIGN_IN_RESPONSE_WRONG_DETAILS "1021"  // [1021]
#define SIGN_IN_RESPONSE_ALREADY_CONNECTED "1022"  // [1022]

#define SIGN_UP_REQUEST "203"  // [203 ##username ##pass ##email]
#define SIGN_UP_RESPONSE "104"  // [See following lines]
#define SIGN_UP_RESPONSE_SUCCESS "1040"  // [1040]
#define SIGN_UP_RESPONSE_PASS_ILLEGAL "1041"  // [1041]
#define SIGN_UP_RESPONSE_USER_EXISTS "1042"  // [1042]
#define SIGN_UP_RESPONSE_USER_ILLEGAL "1043"  // [1043]
#define SIGN_UP_RESPONSE_OTHER "1044"  // [1044]

#define LIVE_ROOMS_REQUEST "205"  // [205]
#define LIVE_ROOMS_RESPONSE "106"  // [106 ####numberOfRooms ####roomId ##roomNameLength roomName...]

#define USERS_IN_ROOM_REQUEST "207"  // [207 ####roomId]
#define USERS_IN_ROOM_RESPONSE "108"  // [108 #numberOfUsers ##usernameLength username...]
#define USERS_IN_ROOM_RESPONSE_NO_ROOM "1080"  // [1080]

#define JOIN_ROOM_REQUEST "209"  // [209 ####roomId]
#define JOIN_ROOM_RESPONSE "110"  // [See following lines]
#define JOIN_ROOM_RESPONSE_SUCCESS "1100"  // [1100 ##questionNumber ##questionTimeInSec]
#define JOIN_ROOM_RESPONSE_ROOM_FULL "1101"  // [1101]
#define JOIN_ROOM_RESPONSE_NO_ROOM_OR_OTHER "1102"  // [1102]

#define LEAVE_ROOM_REQUEST "211"  // [211]
#define LEAVE_ROOM_RESPONSE "112"  // [112]

#define CREATE_ROOM_REQUEST "213"  // [213 ##roomNameLength roomName... #playersNumber ##questionsNumber ##questionTimeInSec]
#define CREATE_ROOM_RESPONSE "114"  // [See following lines]
#define CREATE_ROOM_RESPONSE_SUCCESS "1140"  // [1140]
#define CREATE_ROOM_RESPONSE_FAIL "1141"  // [1141]

#define CLOSE_ROOM_REQUEST "215"  // [215]
#define CLOSE_ROOM_RESPONSE "116"  // [116]

#define START_GAME "217"  // [217] - ONLY FOR ADMINS!

#define QUESTION "118"  // [118 ###questionLength question... ###answer1Length answer1... ###answer2Length answer2... ###answer3Length answer3... ###answer4Length answer4...] - On fail: [1180]
#define CLIENT_ANSWER "219"  // [219 #answerNumber ##timeInSec] - If time was over answerNumber will be 5.
#define IS_CLIENT_CORRECT "120"  // [120 #lastAnswerIndication] - 0=false, 1=true

#define END_GAME "121" // [121 #usersNumber [##usernameLength username...]... ##score]

#define USER_LEFT "222"  // [222]

#define BEST_SCORES_REQUEST "223"  // [223]
#define BEST_SCORES_RESPONSE "124"  // [124 ##username1Length username1... ######username1Score ##username2Length username2... ######username2Score ##username3Length username3... ######username3Score] - If less than 3 users: usernameLength=0, usernameScore=0

#define PERSONAL_STATUS_REQUEST "225"  // [225]
#define PERSONAL_STATUS_RESPONSE "126"  // [126 ####numberOfGames ######numberOfRightAns ######numberOfWrongAns ##avgTimeBeforePoint ## avgTimeAfterPoint]

#define CLIENT_QUIT_APPLICATION "299"  // [299]