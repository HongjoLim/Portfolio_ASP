import React, { Component } from 'react';

export class Jobs extends Component {

    constructor(props){
        super(props);

        this.state = {
            jobs: []
        }
    }

    renderAllJobsTable(jobs){
        return (
            <table clasName="table table-striped">
                <thead>
                    <tr>
                        <th>Title</th>
                        <th>Company</th>
                        <th>City</th>
                        <th>Province</th>
                        <th>Start Date</th>
                        <th>End Date</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                </tbody>
            </table>
        )
    }
    

    render(){
        const content = this.state.loading ? (
            <p><em>Loading...</em></p>
        ) : (
            this.renderAllJobsTable(this.state.jobs)
        )
        return (
        <>
            <h1>All Jobs</h1>
            <p>Here are all jobs</p>
            {content}
        </>
        )
    }
}