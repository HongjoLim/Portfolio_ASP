import React, { Component } from 'react';
import MyPic from '../assets/me.jpg';

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
        <div className="album py-5 bg-light">
          <div className="container">
              <div className="row">
                  <div className="col-md-4">
                    <div className="card mb-4 shadow-sm">
                      <img src = "image.png" height="225"/>
                      <div className="card-body">
                      <p className="card-text"></p>
                      <p className="card-text"></p>
                      </div>
                    </div>
              </div>
          </div>
        </div>
        </div>
      </>
        
    );
  }
}
