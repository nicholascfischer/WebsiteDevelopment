const express = require('express');
const app = express();

const nodemailer = require("nodemailer");

const PORT = process.env.PORT || 5000;

//Middleware
app.use(express.static("public"));
app.use(express.json())

//console.log(__dirname + `what up`);

app.get('/', (req, res) => {
	res.sendFile(__dirname + '/public/contactform.html')
})

app.post("/", (req, res) => {
	//console.log(req.body);

	const transporter = nodemailer.createTransport({
		service: 'gmail',
		auth: {
			user: 'travisheightswiffleballleague@gmail.com',
			pass: 'EXPeriencTraViS'
		}
	})

	const mailOptions = {
		from: req.body.email,
		to: 'travisheightswiffleballleague@gmail.com',
		subject: `Message from ${req.body.email}: ${req.body.subject}`,
		text: req.body.message
	}

	transporter.sendMail(mailOptions, (error, info) => {
		if(error) {
			console.log('error');
		} else {
			console.log('Email Sent! ' + info.response);
			res.send('success')
		}
	})
})

app.listen(PORT, () => {
	console.log(`Server running on port ${PORT}`)
})