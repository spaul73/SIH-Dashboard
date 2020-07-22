var firebaseConfig = {
    apiKey: "AIzaSyDo48RL0DQtlrq8uOp-X-BBBqJRcYRUJDg",
    authDomain: "trans-setup-257313.firebaseapp.com",
    databaseURL: "https://trans-setup-257313.firebaseio.com",
    projectId: "trans-setup-257313",
    storageBucket: "trans-setup-257313.appspot.com",
    messagingSenderId: "199528645527",
    appId: "1:199528645527:web:2f53a1b9eaeca0bfc3bad2",
    measurementId: "G-HC050E3EZC"
};


// Initialize Firebase
firebase.initializeApp(firebaseConfig);
firebase.analytics();
var database = firebase.database();







async function signUpUser(email, password) {
    try {
        let res = await firebase.auth().createUserWithEmailAndPassword(email, password);
        let payload =
        {
            "status": true,
            "uid": res.user.uid,
            "emailVerified":res.user.emailVerified
        };
        return payload;
    }
    catch (err) {
        let payload=
        {
            "status": false,
            "message": err.toString()
        };
        return payload;
    }
}

async function signInUser(email, password) {
    try {
        let res = await firebase.auth().signInWithEmailAndPassword(email, password);
        let payload =
        {
            "status": true,
            "uid": res.user.uid,
            "emailVerified": res.user.emailVerified
        };
        return payload;

    }
    catch (err) {
        let payload =
        {
            "status": false,
            "message": err.toString()
        };
        return payload;
    }
}
async function resetPassword(email) {
    try {
        let res = await firebase.auth().sendPasswordResetEmail(email);
        let payload =
        {
            "status": true,
        };
        return payload;

    }
    catch (err) {
        let payload =
        {
            "status": false,
            "message": err.toString()
        };
        return payload;
    }
}
async function verifyEmail() {
    try {
        let res = await firebase.auth().currentUser.sendEmailVerification();
        let payload =
        {
            "status": true,
        };
        return payload;

    }
    catch (err) {
        let payload =
        {
            "status": false,
            "message": err.toString()
        };
        return payload;
    }
}

async function logout() {
    try {
        let res = await firebase.auth().signOut();
        let payload =
        {
            "status": true,
        };
        return payload;

    }
    catch (err) {
        let payload =
        {
            "status": false,
            "message": err.toString()
        };
        return payload;
    }
}


function print(val) {
    console.log(val);
}

function WriteData(path, val)
{
    database.ref(path).set(val);
}

//Can now read List 
async function ReadData(path)
{
    const v = await database.ref(path).once('value');
    return v.val();
}

function PushData(path, val)
{
    database.ref(path).push().set(val);
}

//Returns list of objects to be used in conjuction with ReadList() wrapper
async function ReadList(path) {
    return await database.ref(path).once('value').then(function (snapshot) {
        var lst = [];
        snapshot.forEach(function (childSnapshot) {
            var obj = childSnapshot.val();
            lst.push(obj);
        });
        return lst;
    });
}

async function GetIds(path) {
    return await database.ref(path).once('value').then(function (snapshot) {
        var ids = [];
        snapshot.forEach(function (childSnapshot) {
            var obj = childSnapshot.key;
            ids.push(obj);
        });
        return ids;
    });
}

async function GetFeedbacks(path) {
    var ids = await GetIds(path);
    var feeds = [];
    for (const id of ids) {
        var feed = await database.ref("Feedbacks/" + id).once('value').then(function (snapshot) {
            var feed = snapshot.val();
            feed.id = snapshot.key;
            return feed;});
        feeds.push(feed);
    }
    return feeds;
}