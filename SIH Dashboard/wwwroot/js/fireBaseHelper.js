﻿var firebaseConfig = {
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

async function ReadData(path)
{
    return await database.ref(path).once('value');
}
