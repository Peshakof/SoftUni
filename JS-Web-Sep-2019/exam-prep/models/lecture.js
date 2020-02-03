const mongoose = require('mongoose');

const lectureSchema = new mongoose.Schema({
    title: {
        type: String,
        required: true
    },
    videoUrl: {
        type: String,
        required: true
    },
    cource: {
        type: mongoose.Schema.Types.ObjectId, ref: 'Cource'
    }
})

module.exports = mongoose.model('Lecture', lectureSchema);