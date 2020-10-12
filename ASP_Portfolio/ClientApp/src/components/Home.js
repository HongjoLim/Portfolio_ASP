import React, { Component } from 'react';
import MyPic from '../assets/images/me.jpg';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
          <section id="intro" className="wrapper style1 fullscreen fade-up">
						<div className="inner">
							<h1>Hongjo Lim</h1>
							<p>Software Developer</p><br/>
							<ul className="actions">
								<li><a href="#one" className="button scrolly">Learn more</a></li>
							</ul>
						</div>
					</section>
        
    );
  }
}
