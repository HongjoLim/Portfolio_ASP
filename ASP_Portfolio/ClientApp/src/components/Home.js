import React, { Component } from 'react';
import MyPic from '../assets/images/me.jpg';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
    <>
    {console.log(MyPic)}
        <section className="jumbotron text-center">
          <div className="container">
            <img src={MyPic} height="300" id="profile" alt="My Picture"/>
            <br/><br/>
            <h1>Hongjo Lim</h1>
            <br/>
            <p className="lead text-muted">.NET, C#, Android, Python Developer</p>
            <p>
                <a href="mailto:hongjo1988@gmail.com" className="btn btn-primary my-2">Email Me</a>
            </p>
          </div>
        </section>
      </>
        
    );
  }
}
