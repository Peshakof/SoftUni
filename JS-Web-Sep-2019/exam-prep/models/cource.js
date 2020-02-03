const mongoose = require('mongoose');

const courcesSchema = new mongoose.Schema({
    title: {
        type: String,
        required: true
    },
    description: {
        type: String,
        required: true
    },
    imageUrl: {
        type: String,
        required: true
    },
    isPublic: {
        type: Boolean
    },
    lectures: [{
        type: mongoose.Schema.Types.ObjectId, ref: 'Lecture'
    }],
    usersEnrolled: [{
        type: mongoose.Schema.Types.ObjectId, ref: 'User'
    }]
})

module.exports = mongoose.model('Cource', courcesSchema);